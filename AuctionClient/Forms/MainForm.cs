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
            dgvAuctions.Columns.Clear();

            dgvAuctions.Columns.Add("Id", "ID");
            dgvAuctions.Columns.Add("Name", "Tên sản phẩm");
            dgvAuctions.Columns.Add("Price", "Giá khởi điểm");
            dgvAuctions.Columns.Add("ImageFile", "Ảnh");

            dgvAuctions.Columns["ImageFile"].Visible = false;

            dgvAuctions.Rows.Add("1", "IPhone 15", "2000", "iphone-15-xanh.jpg");
            dgvAuctions.Rows.Add("2", "Đồng hồ Casio", "15000", "Casio.jpg");

            dgvAuctions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuctions.MultiSelect = false;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (dgvAuctions.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiên đấu giá!");
                return;
            }

            string auctionId = dgvAuctions.CurrentRow.Cells["Id"].Value.ToString();
            string name = dgvAuctions.CurrentRow.Cells["Name"].Value.ToString();
            int price = int.Parse(dgvAuctions.CurrentRow.Cells["Price"].Value.ToString());
            string imageFile = dgvAuctions.CurrentRow.Cells["ImageFile"].Value.ToString();

            AuctionForm frm = new AuctionForm(auctionId, name, price, imageFile);

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
