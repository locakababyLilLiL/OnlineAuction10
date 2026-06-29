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

            byte[] buffer = new byte[1024];

            while (true)
            {
                int n = stream.Read(buffer, 0, buffer.Length);

                if (n == 0)
                    break;

                string message = Encoding.UTF8.GetString(buffer, 0, n);

                Invoke(new Action(() =>
                {
                    rtbLog.AppendText("Client: " + message + "\n");
                }));

                string[] data = message.Split('|');

                string command = data[0];

                //==== REGISTER =====
                if (command == "REGISTER")
                {
                    User newUser = new User();

                    newUser.Username = data[1];
                    newUser.Password = data[2];

                    users.Add(newUser);

                    byte[] sendRegister = Encoding.UTF8.GetBytes("Đăng ký thành công");

                    stream.Write(sendRegister, 0, sendRegister.Length);

                    continue;
                }

                //====LOGIN ===
                if (command == "LOGIN")
                {
                    bool ok = false;

                    foreach (User user in users)
                    {
                        if (user.Username == data[1] &&
                            user.Password == data[2])
                        {
                            ok = true;
                            break;
                        }
                    }

                    string reply;

                    if (ok)
                        reply = "Đăng nhập thành công";
                    else
                        reply = "Sai tài khoản";

                    byte[] sendLogin = Encoding.UTF8.GetBytes(reply);

                    stream.Write(sendLogin, 0, sendLogin.Length);

                    continue;
                }

                //view item 
                if (command == "VIEW")
                {
                    string info =
                        item.ItemName + "|" +
                        item.CurrentPrice + "|" +
                        item.HighestBidder;

                    byte[] sendView = Encoding.UTF8.GetBytes(info);

                    stream.Write(sendView, 0, sendView.Length);

                    continue;
                }
                //====== BID =
                if (command == "BID")
                {
                    if (auctionEnded)
                    {
                        byte[] send = Encoding.UTF8.GetBytes("Phiên đấu giá đã kết thúc");
                        stream.Write(send, 0, send.Length);
                        continue;
                    }
                    string username = data[1];
                    int newPrice = int.Parse(data[2]);

                    if (newPrice > item.CurrentPrice)
                    {
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

                            rtbLog.AppendText(username + " đặt giá: "
                                + newPrice.ToString("N0") + " VNĐ\n");
                        }));

                        byte[] sendBid = Encoding.UTF8.GetBytes("Đặt giá thành công");
                        stream.Write(sendBid, 0, sendBid.Length);
                    }
                    else
                    {
                        byte[] sendBid = Encoding.UTF8.GetBytes("Giá phải lớn hơn giá hiện tại");
                        stream.Write(sendBid, 0, sendBid.Length);
                    }

                    continue;
                }
            }

            client.Close();
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

                MessageBox.Show(
                    "Người thắng: " + item.HighestBidder +
                    "\nGiá: " + item.CurrentPrice.ToString("N0") + " VNĐ");

                foreach (Bid b in bidHistory)
                {
                    File.AppendAllText(
                        "History.txt",
                        b.Username + " | " +
                        b.Price + " | " +
                        b.Time +
                        Environment.NewLine);
                }

                rtbLog.AppendText("\nĐã lưu lịch sử đấu giá.\n");
            }
        }
        
    }
}
