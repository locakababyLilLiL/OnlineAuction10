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

        Dictionary<string, AuctionRoom> rooms = new Dictionary<string, AuctionRoom>();

        bool isRunning = false;

        readonly object clientsLock = new object();
        readonly object roomsLock = new object();
        public Form1()
        {
            InitializeComponent();
            InitRooms();
        }
        private void InitRooms()
        {
            rooms.Clear();

            rooms["1"] = new AuctionRoom
            {
                AuctionId = "1",
                ItemName = "IPhone 15 Pro Max",
                StartPrice = 2000,
                CurrentPrice = 0,
                HighestBidder = "Chưa có",
                EndTime = DateTime.Now.AddMinutes(5),
                AuctionEnded = false
            };

            rooms["2"] = new AuctionRoom
            {
                AuctionId = "2",
                ItemName = "Đồng hồ Casio",
                StartPrice = 50000,
                CurrentPrice = 0,
                HighestBidder = "Chưa có",
                EndTime = DateTime.Now.AddMinutes(5),
                AuctionEnded = false
            };
        }
        private void UpdateRoomInfo(string auctionId)
        {
            if (!rooms.ContainsKey(auctionId))
                return;

            AuctionRoom room = rooms[auctionId];

            lblProduct.Text = room.ItemName;

            // Giá khởi điểm luôn cố định
            lblPrice.Text = room.StartPrice.ToString("N0") + " $";

            // Giá hiện tại mới được cập nhật
            if (room.CurrentPrice == 0)
            {
                lblStartPrice.Text = "Chưa có ai đặt";
            }
            else
            {
                lblStartPrice.Text = room.CurrentPrice.ToString("N0") + " $";
            }

            lblWinner.Text = room.HighestBidder;
            lblTime.Text = GetTimeText(room);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            btnStop.Enabled = false;

            lblPrice.Text = "Phòng 1: " + rooms["1"].CurrentPrice.ToString("N0") + " $";
            lblWinner.Text = rooms["1"].HighestBidder;
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
                InitRooms();

                lblPrice.Text = "Phòng 1: " + rooms["1"].CurrentPrice.ToString("N0") + " $";
                lblWinner.Text = rooms["1"].HighestBidder;
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
        private string GetTimeText(AuctionRoom room)
        {
            TimeSpan t = room.EndTime - DateTime.Now;

            if (t.TotalSeconds <= 0)
                return "Đã kết thúc";

            return t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00");
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
                    if (data.Length < 3)
                    {
                        Send(stream, "ERROR|Thiếu mã phòng hoặc username");
                        continue;
                    }

                    string auctionId = data[1];
                    string username = data[2];

                    if (!rooms.ContainsKey(auctionId))
                    {
                        Send(stream, "ERROR|Phòng đấu giá không tồn tại");
                        continue;
                    }

                    AuctionRoom room = rooms[auctionId];

                    lock (room.RoomLock)
                    {
                        if (!room.Clients.Contains(client))
                        {
                            room.Clients.Add(client);
                        }
                    }

                    string timeText = GetTimeText(room);
                    Send(stream,
                        "JOIN|" +
                        auctionId + "|" +
                        room.StartPrice + "|" +
                        room.CurrentPrice + "|" +
                        GetTimeText(room) + "|" +
                        room.HighestBidder
                    );

                    AddLog(username + " tham gia phòng đấu giá ID: " + auctionId);

                    continue;
                }

                //---------------------------------------
                // BID
                //---------------------------------------
                if (command == "BID")
                {
                    if (data.Length < 4)
                    {
                        Send(stream, "ERROR|Sai dữ liệu đặt giá");
                        continue;
                    }

                    string auctionId = data[1];
                    string username = data[2];

                    if (!int.TryParse(data[3], out int newPrice))
                    {
                        Send(stream, "ERROR|Giá không hợp lệ");
                        continue;
                    }

                    if (!rooms.ContainsKey(auctionId))
                    {
                        Send(stream, "ERROR|Phòng đấu giá không tồn tại");
                        continue;
                    }

                    AuctionRoom room = rooms[auctionId];

                    lock (room.RoomLock)
                    {
                        if (room.AuctionEnded)
                        {
                            Send(stream, "ERROR|Phiên đấu giá đã kết thúc");
                            continue;
                        }

                        if (room.CurrentPrice == 0)
                        {
                            if (newPrice < room.StartPrice)
                            {
                                Send(stream, "ERROR|Giá đặt phải lớn hơn hoặc bằng giá khởi điểm: " + room.StartPrice.ToString("N0") + " $");
                                continue;
                            }
                        }
                        else
                        {
                            if (newPrice <= room.CurrentPrice)
                            {
                                Send(stream, "ERROR|Giá đặt phải lớn hơn giá hiện tại: " + room.CurrentPrice.ToString("N0") + " $");
                                continue;
                            }
                        }

                        room.CurrentPrice = newPrice;
                        room.HighestBidder = username;

                        room.BidHistory.Add(new Bid
                        {
                            Username = username,
                            Price = newPrice,
                            Time = DateTime.Now
                        });
                    }

                    Invoke(new Action(() =>
                    {
                        UpdateRoomInfo(auctionId);
                    }));

                    AddLog("Phòng " + auctionId + ": " + username + " đặt giá "
                        + newPrice.ToString("N0") + " $");

                    BroadcastToRoom(room, "BID|" + auctionId + "|" + username + "|" + newPrice);

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
        private void BroadcastToRoom(AuctionRoom room, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            lock (room.RoomLock)
            {
                foreach (TcpClient c in room.Clients.ToList())
                {
                    try
                    {
                        NetworkStream s = c.GetStream();
                        s.Write(data, 0, data.Length);
                    }
                    catch
                    {
                        room.Clients.Remove(c);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (AuctionRoom room in rooms.Values.ToList())
            {
                lock (room.RoomLock)
                {
                    if (room.AuctionEnded)
                        continue;

                    TimeSpan t = room.EndTime - DateTime.Now;

                    if (t.TotalSeconds > 0)
                    {
                        string timeText = t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00");

                        if (room.AuctionId == "1")
                        {
                            lblTime.Text = timeText;
                        }

                        BroadcastToRoom(room, "TIME|" + room.AuctionId + "|" + timeText);
                    }
                    else
                    {
                        room.AuctionEnded = true;

                        if (room.AuctionId == "1")
                        {
                            lblTime.Text = "Đã kết thúc";
                        }

                        AddLog("===== PHÒNG " + room.AuctionId + " KẾT THÚC =====");
                        AddLog("Sản phẩm: " + room.ItemName);
                        AddLog("Người thắng: " + room.HighestBidder);
                        AddLog("Giá thắng: " + room.CurrentPrice.ToString("N0") + " $");

                        BroadcastToRoom(room, "END|" + room.AuctionId + "|" + room.HighestBidder + "|" + room.CurrentPrice);

                        foreach (Bid b in room.BidHistory)
                        {
                            File.AppendAllText(
                                "History_Room_" + room.AuctionId + ".txt",
                                b.Username + " | " +
                                b.Price + " | " +
                                b.Time +
                                Environment.NewLine);
                        }

                        AddLog("Đã lưu lịch sử phòng " + room.AuctionId);
                    }
                }
            }

            bool allEnded = rooms.Values.All(r => r.AuctionEnded);

            if (allEnded)
            {
                timer1.Stop();
                AddLog("Tất cả phòng đấu giá đã kết thúc.");
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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
