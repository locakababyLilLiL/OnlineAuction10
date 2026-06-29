using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionClient.Forms
{
    public partial class AuctionForm : Form
    {
        private TcpClientService tcp = new TcpClientService();
        private string auctionId;

        public AuctionForm(string id)
        {
            InitializeComponent();
            auctionId = id;
        }

        private void AuctionForm_Load(object sender, EventArgs e)
        {
            tcp.Connect("127.0.0.1", 9999);

            tcp.OnMessageReceived += Tcp_OnMessageReceived;

            tcp.Send($"JOIN|{auctionId}|{LoginForm.CurrentUser}");
        }

        private void Tcp_OnMessageReceived(string msg)
        {
            Invoke(new Action(() =>
            {
                ProcessMessage(msg);
            }));
        }

        private void ProcessMessage(string msg)
        {
            string[] parts = msg.Split('|');

            switch (parts[0])
            {
                case "JOIN":
                    lblPrice.Text = parts[1];
                    break;

                case "BID":
                    lblPrice.Text = parts[2];
                    lstHistory.Items.Add($"{parts[1]} : {parts[2]}");
                    break;

                case "ERROR":
                    MessageBox.Show(parts[1]);
                    break;

                case "END":
                    btnBid.Enabled = false;
                    MessageBox.Show("Winner: " + parts[1]);
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

            if (!decimal.TryParse(txtBid.Text, out decimal bidPrice))
            {
                MessageBox.Show("Giá đấu không hợp lệ!");
                txtBid.SelectAll();
                txtBid.Focus();
                return;
            }

            decimal currentPrice = 0;

            decimal.TryParse(lblPrice.Text, out currentPrice);

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
    }
}
