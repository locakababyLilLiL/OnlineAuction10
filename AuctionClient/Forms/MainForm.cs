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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvAuctions.Columns.Add("Id", "ID");
            dgvAuctions.Columns.Add("Name", "Tên");
            dgvAuctions.Columns.Add("Price", "Giá");

            dgvAuctions.Rows.Add("1", "iPhone 15", "20000000");
            dgvAuctions.Rows.Add("2", "Laptop", "15000000");
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (dgvAuctions.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiên đấu giá!");
                return;
            }

            string auctionId = dgvAuctions.CurrentRow.Cells["Id"].Value.ToString();

            AuctionForm frm = new AuctionForm(auctionId);

            this.Hide();          // Ẩn MainForm
            frm.ShowDialog();     // Chờ đến khi đóng AuctionForm
            this.Show();          // Hiện lại MainForm
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
