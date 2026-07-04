using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace AuctionServer
{
    public partial class Form1 : Form
    {
        TcpListener server;
        Thread serverThread;

        List<TcpClient> clients = new List<TcpClient>();
        List<User> users = new List<User>();
        List<Bid> bidHistory = new List<Bid>();

        AuctionItem item = new AuctionItem();

        bool auctionEnded = false;
        public Form1()
        {
            InitializeComponent();
            item.ItemName = "IPhone 17 Pro Max";
            item.CurrentPrice = 10000000;
            item.HighestBidder = "Chưa có";
            item.EndTime = DateTime.Now.AddMinutes(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 9999);
            server.Start();

            MessageBox.Show("Server đã khởi động!");

            serverThread = new Thread(ListenClient);
            serverThread.IsBackground = true;
            serverThread.Start();

            timer1.Interval = 1000;
            timer1.Start();
        }
        private void ListenClient()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                clients.Add(client);

                Invoke(new Action(() =>
                {
                    rtbLog.AppendText("Có Client kết nối!\n");
                }));

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }
        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[4096];

            while (true)
            {
                int n;

                try
                {
                    n = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    break;
                }

                if (n <= 0)
                    break;

                string message = Encoding.UTF8.GetString(buffer, 0, n);

                Invoke(new Action(() =>
                {
                    rtbLog.AppendText("Client: " + message + Environment.NewLine);
                }));

                string[] data = message.Split('|');

                string command = data[0];


                // REGISTER

                if (command == "REGISTER")
                {
                    string username = data[1];
                    string password = data[2];

                    bool exist = users.Any(x => x.Username == username);

                    if (exist)
                    {
                        Send(stream, "Tên đăng nhập đã tồn tại");
                    }
                    else
                    {
                        users.Add(new User
                        {
                            Username = username,
                            Password = password
                        });

                        Send(stream, "Đăng ký thành công");
                    }

                    continue;
                }

                //---------------------------------------
                // LOGIN
                //---------------------------------------
                if (command == "LOGIN")
                {
                    bool ok = users.Any(x =>
                            x.Username == data[1] &&
                            x.Password == data[2]);

                    if (ok)
                        Send(stream, "Đăng nhập thành công");
                    else
                        Send(stream, "Sai tài khoản");

                    continue;
                }

                //---------------------------------------
                // JOIN
                //---------------------------------------
                if (command == "JOIN")
                {
                    Send(stream, $"JOIN|{item.CurrentPrice}");
                    continue;
                }

                //---------------------------------------
                // BID
                //---------------------------------------
                if (command == "BID")
                {
                    if (auctionEnded)
                    {
                        Send(stream, "END|" + item.HighestBidder);
                        continue;
                    }

                    if (data.Length < 4)
                    {
                        Send(stream, "ERROR|Sai dữ liệu");
                        continue;
                    }

                    string auctionId = data[1];

                    string username = data[2];

                    int newPrice;

                    if (!int.TryParse(data[3], out newPrice))
                    {
                        Send(stream, "ERROR|Giá không hợp lệ");
                        continue;
                    }

                    if (newPrice <= item.CurrentPrice)
                    {
                        Send(stream, "ERROR|Giá phải lớn hơn giá hiện tại");
                        continue;
                    }

                    item.CurrentPrice = newPrice;
                    item.HighestBidder = username;

                    Bid bid = new Bid();

                    bid.Username = username;
                    bid.Price = newPrice;
                    bid.Time = DateTime.Now;

                    bidHistory.Add(bid);

                    Invoke(new Action(() =>
                    {
                        lblPrice.Text = item.CurrentPrice.ToString("N0") + " VNĐ";
                        lblWinner.Text = item.HighestBidder;

                        rtbLog.AppendText(
                            username +
                            " đặt giá " +
                            item.CurrentPrice.ToString("N0") +
                            " VNĐ" +
                            Environment.NewLine);
                    }));

                    Broadcast(
                             $"BID|{username}|{item.CurrentPrice}");

                    continue;
                }
            }

            client.Close();
        }
        // hàm send dữ liệu đến client

        private void Send(NetworkStream stream, string msg)


        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            stream.Write(data, 0, data.Length);
        }
        // hàm broadcast dữ liệu đến tất cả client
        private void Broadcast(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            foreach (TcpClient c in clients.ToList())
            {
                try
                {
                    NetworkStream s = c.GetStream();

                    s.Write(data, 0, data.Length);
                }
                catch
                {
                    clients.Remove(c);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = item.EndTime - DateTime.Now;

            if (t.TotalSeconds > 0)
            {
                lblTime.Text = t.Minutes + ":" + t.Seconds.ToString("00");
            }
            else
            {
                lblTime.Text = "Đã kết thúc";
                timer1.Stop();

                auctionEnded = true;

                rtbLog.AppendText(Environment.NewLine);
                rtbLog.AppendText("===== PHIÊN ĐẤU GIÁ KẾT THÚC =====");
                rtbLog.AppendText(Environment.NewLine);
                rtbLog.AppendText("Người thắng: " + item.HighestBidder);
                rtbLog.AppendText(Environment.NewLine);
                rtbLog.AppendText("Giá thắng: " + item.CurrentPrice.ToString("N0"));
                rtbLog.AppendText(Environment.NewLine);

                foreach (Bid b in bidHistory)
                {
                    File.AppendAllText(
                        "History.txt",
                        b.Username + " | " +
                        b.Price + " | " +
                        b.Time +
                        Environment.NewLine);
                }
                rtbLog.AppendText("Phiên đấu giá kết thúc\n");
                rtbLog.AppendText("\nĐã lưu lịch sử đấu giá.\n");
            }
        }

        private void rtbLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();

                if (server != null)
                    server.Stop();

                rtbLog.AppendText("Server đã dừng.\n");
            }
            catch
            {

            }
        }

       
    }
}
