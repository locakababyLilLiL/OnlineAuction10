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
        bool isRunning = false;
        readonly object clientsLock = new object();
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
            btnStop.Enabled = false;

            lblPrice.Text = item.CurrentPrice.ToString("N0") + " VNĐ";
            lblWinner.Text = item.HighestBidder;
            lblTime.Text = "05:00";

            AddLog("Server chưa chạy. Bấm Start để bắt đầu.");
        }
        private void AddLog(string text)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action(() => AddLog(text)));
                return;
            }

            rtbLog.AppendText(DateTime.Now.ToString("HH:mm:ss") + " - " + text + Environment.NewLine);
            rtbLog.ScrollToCaret();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (isRunning)
                {
                    AddLog("Server đang chạy rồi.");
                    return;
                }

                server = new TcpListener(IPAddress.Any, 9999);
                server.Start();

                isRunning = true;
                auctionEnded = false;

                item.EndTime = DateTime.Now.AddMinutes(5);
                item.CurrentPrice = 10000;
                item.HighestBidder = "Chưa có";

                lblPrice.Text = "💰 Giá hiện tại : " + item.CurrentPrice.ToString("N0") + " $";
                lblWinner.Text = item.HighestBidder;
                lblTime.Text = "05:00";

                AddLog("Server đã khởi động trên port 9999.");
                AddLog("Đang chờ Client kết nối...");

                serverThread = new Thread(ListenClient);
                serverThread.IsBackground = true;
                serverThread.Start();

                timer1.Start();

                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            catch (SocketException ex)
            {
                AddLog("Không Start được Server: " + ex.Message);
                MessageBox.Show("Không Start được Server. Có thể port 9999 đang bị dùng.");
            }
            catch (Exception ex)
            {
                AddLog("Lỗi Start Server: " + ex.Message);
                MessageBox.Show("Lỗi Start Server: " + ex.Message);
            }
        }
        private void ListenClient()
        {
            while (isRunning)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();

                    lock (clientsLock)
                    {
                        clients.Add(client);
                    }

                    AddLog("Có Client kết nối: " + client.Client.RemoteEndPoint);

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
                catch
                {
                    if (isRunning)
                    {
                        AddLog("Lỗi khi nhận Client.");
                    }

                    break;
                }
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
                    if (data.Length < 3)
                    {
                        Send(stream, "ERROR|Thiếu username hoặc password");
                        continue;
                    }

                    string username = data[1];
                    string password = data[2];

                    bool exist = users.Any(x => x.Username == username);

                    if (exist)
                    {
                        Send(stream, "ERROR|Tên đăng nhập đã tồn tại");
                        AddLog("Đăng ký thất bại, tài khoản đã tồn tại: " + username);
                    }
                    else
                    {
                        users.Add(new User
                        {
                            Username = username,
                            Password = password
                        });

                        Send(stream, "REGISTER_OK|Đăng ký thành công");
                        AddLog("Đăng ký tài khoản mới: " + username);
                    }

                    continue;
                }

                //---------------------------------------
                // LOGIN
                //---------------------------------------
                if (command == "LOGIN")
                {
                    if (data.Length < 3)
                    {
                        Send(stream, "ERROR|Thiếu username hoặc password");
                        continue;
                    }

                    string username = data[1];
                    string password = data[2];

                    bool ok = users.Any(x =>
                        x.Username == username &&
                        x.Password == password);

                    if (ok)
                    {
                        Send(stream, "LOGIN_OK|Đăng nhập thành công");
                        AddLog("Đăng nhập thành công: " + username);
                    }
                    else
                    {
                        Send(stream, "ERROR|Sai tài khoản hoặc mật khẩu");
                        AddLog("Đăng nhập thất bại: " + username);
                    }

                    continue;
                }

                //---------------------------------------
                // JOIN
                //---------------------------------------
                if (command == "JOIN")
                {
                    string timeText = lblTime.Text;

                    if (data.Length >= 3)
                    {
                        AddLog(data[2] + " tham gia phiên đấu giá ID: " + data[1]);
                    }
                    else
                    {
                        AddLog("Có client tham gia phiên đấu giá.");
                    }

                    Send(stream, $"JOIN|{item.CurrentPrice}|{timeText}");
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

                    Invoke(new Action(() =>
                    {
                        lblPrice.Text = item.CurrentPrice.ToString("N0") + " $";
                        lblWinner.Text = item.HighestBidder;
                    }));

                    AddLog(username + " đặt giá " + item.CurrentPrice.ToString("N0") + " $");

                    bidHistory.Add(bid);

                    AddLog("Client gửi: " + message);

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
                string timeText = t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00");
                lblTime.Text = timeText;

                Broadcast("TIME|" + timeText);
            }
            else
            {
                lblTime.Text = "Đã kết thúc";
                timer1.Stop();

                if (auctionEnded)
                    return;

                auctionEnded = true;

                AddLog("===== PHIÊN ĐẤU GIÁ KẾT THÚC =====");
                AddLog("Người thắng: " + item.HighestBidder);
                AddLog("Giá thắng: " + item.CurrentPrice.ToString("N0") + " $");

                Broadcast("END|" + item.HighestBidder);

                foreach (Bid b in bidHistory)
                {
                    File.AppendAllText(
                        "History.txt",
                        b.Username + " | " +
                        b.Price + " | " +
                        b.Time +
                        Environment.NewLine);
                }

                AddLog("Đã lưu lịch sử đấu giá.");
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
                isRunning = false;
                timer1.Stop();

                lock (clientsLock)
                {
                    foreach (TcpClient c in clients.ToList())
                    {
                        try
                        {
                            c.Close();
                        }
                        catch
                        {
                        }
                    }

                    clients.Clear();
                }

                if (server != null)
                {
                    server.Stop();
                    server = null;
                }

                AddLog("Server đã dừng.");

                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch (Exception ex)
            {
                AddLog("Lỗi Stop Server: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
