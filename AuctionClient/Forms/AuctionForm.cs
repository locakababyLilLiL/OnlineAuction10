using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AuctionClient.Forms
{
    public partial class AuctionForm : Form
    {
        private TcpClientService tcp = new TcpClientService();

        private string auctionId;
        private string auctionName;
        private string imageFile;
        private int currentPrice;

        public AuctionForm(string id, string name, int price, string image)
        {
            InitializeComponent();

            auctionId = id;
            auctionName = name;
            currentPrice = price;
            imageFile = image;
        }
        public AuctionForm(string id)
        {
            InitializeComponent();

            auctionId = id;
            auctionName = "Sản phẩm đấu giá";
            currentPrice = 0;
            imageFile = "";
        }

        private void AuctionForm_Load(object sender, EventArgs e)
        {
            lblItem.Text = $"📦 Item: {auctionName} | ID: {auctionId}";
            lblPrice.Text = "💰 Giá hiện tại : " + currentPrice.ToString("N0") + "$";
            lblCountdown.Text = "⏱ 05:00";

            LoadItemImage();

            tcp.OnMessageReceived += Tcp_OnMessageReceived;
            tcp.Connect("127.0.0.1", 9999);

            tcp.Send($"JOIN|{auctionId}|{LoginForm.CurrentUser}");
        }
        private void LoadItemImage()
        {
            string path = Path.Combine(Application.StartupPath, "Images", imageFile);

            if (File.Exists(path))
            {
                picItem.SizeMode = PictureBoxSizeMode.Zoom;
                picItem.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh: " + path);
            }
        }
        private void Tcp_OnMessageReceived(string msg)
        {
            try
            {
                if (this.IsDisposed || !this.IsHandleCreated)
                    return;

                this.Invoke(new Action(() =>
                {
                    ProcessMessage(msg);
                }));
            }
            catch
            {
               
            }
        }

        private void ProcessMessage(string msg)
        {
            string[] parts = msg.Split('|');

            if (parts.Length == 0)
                return;

            switch (parts[0])
            {
                case "JOIN":
                    if (parts.Length >= 2)
                    {
                        if (int.TryParse(parts[1], out int price))
                        {
                            currentPrice = price;
                            lblPrice.Text = "💰 Giá hiện tại: " + currentPrice.ToString("N0") + " $";
                        }
                    }

                    if (parts.Length >= 3)
                    {
                        lblCountdown.Text = "⏱ " + parts[2];
                    }
                    break;

                case "TIME":
                    if (parts.Length >= 2)
                    {
                        lblCountdown.Text = "⏱ " + parts[1];
                    }
                    break;

                case "BID":
                    if (parts.Length >= 3)
                    {
                        if (int.TryParse(parts[2], out int newPrice))
                        {
                            currentPrice = newPrice;
                            lblPrice.Text = "💰 Giá hiện tại: " + currentPrice.ToString("N0") + " $";
                            lstHistory.Items.Add(parts[1] + " : " + currentPrice.ToString("N0") + " $");
                        }
                    }
                    break;

                case "ERROR":
                    if (parts.Length >= 2)
                        MessageBox.Show(parts[1]);
                    else
                        MessageBox.Show("Có lỗi xảy ra!");
                    break;

                case "END":
                    btnBid.Enabled = false;
                    lblCountdown.Text = "⏱ Đã kết thúc";

                    if (parts.Length >= 2)
                        MessageBox.Show("Winner: " + parts[1]);
                    else
                        MessageBox.Show("Phiên đấu giá đã kết thúc!");
                    break;
            }
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBid.Text))
            {
                MessageBox.Show("Vui lòng nhập giá đấu!");
                txtBid.Focus();
                return;
            }

            if (!int.TryParse(txtBid.Text, out int bidPrice))
            {
                MessageBox.Show("Giá đấu không hợp lệ!");
                txtBid.SelectAll();
                txtBid.Focus();
                return;
            }

            if (bidPrice <= currentPrice)
            {
                MessageBox.Show("Giá đấu phải lớn hơn giá hiện tại!");
                txtBid.SelectAll();
                txtBid.Focus();
                return;
            }

            tcp.Send($"BID|{auctionId}|{LoginForm.CurrentUser}|{bidPrice}");

            txtBid.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {

        }

        private void picItem_Click(object sender, EventArgs e)
        {

        }
    }
}
