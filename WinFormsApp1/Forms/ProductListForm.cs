using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Services;

namespace WinFormsApp1.Forms
{
    public partial class ProductListForm : Form
    {
        private readonly ApiService _api = new ApiService();
        private List<Auction> _auctions = new();

        public ProductListForm()
        {
            InitializeComponent();
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.DoubleClick += DgvProducts_DoubleClick;
        }

        private async void ProductListForm_Load(object sender, EventArgs e)
        {
            await LoadAuctions();
        }

        private async Task LoadAuctions()
        {
            try
            {
                _auctions = await _api.GetAuctions();
                dgvProducts.DataSource = _auctions.Select(a => new
                {
                    ID = a.Id,
                    TenSanPham = a.Title,
                    GiaHienTai = a.CurrentPrice.ToString("N0") + " đ",
                    ThoiGianKetThuc = a.EndTime.ToString("dd/MM/yyyy HH:mm"),
                    TrangThai = a.Status == 1 ? "Đang đấu giá" : "Đã kết thúc"
                }).ToList();
            }
            catch
            {
                MessageBox.Show("Không thể tải danh sách. Kiểm tra kết nối Server!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProducts_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int index = dgvProducts.CurrentRow.Index;
            if (index < 0 || index >= _auctions.Count) return;

            var selected = _auctions[index];
            new AuctionDetailForm(selected).Show();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
