using Microsoft.AspNetCore.SignalR.Client;
using WinFormsApp1.Models;
using WinFormsApp1.Services;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Forms
{
    public partial class AuctionDetailForm : Form
    {
        private readonly ApiService _api = new ApiService();
        private readonly Auction _auction;
        private HubConnection? _hubConnection;
        private DateTime _endTime;

        public AuctionDetailForm(Auction auction)
        {
            InitializeComponent();
            _auction = auction;
            _endTime = auction.EndTime;

            // Gán sự kiện
            this.Load += AuctionDetailForm_Load;
            btnBid.Click += BtnBid_Click;
            timer1.Tick += Timer1_Tick;
        }

        // ── Khi form mở ──────────────────────────────────────
        private async void AuctionDetailForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin sản phẩm
            lblTitle.Text = _auction.Title;
            lblCurrentPrice.Text = $"Giá hiện tại: {_auction.CurrentPrice:N0} đ";
            label2.Text = $"Bước giá: {_auction.StepPrice:N0} đ";

            // Cấu hình bảng lịch sử
            dgvHistory.Columns.Clear();
            dgvHistory.Columns.Add("FullName", "Người đặt");
            dgvHistory.Columns.Add("BidAmount", "Số tiền");
            dgvHistory.Columns.Add("BidTime", "Thời gian");
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load lịch sử từ API
            await LoadHistory();

            // Bắt đầu đếm ngược
            timer1.Start();

            // Kết nối SignalR
            await ConnectSignalR();
        }

        // ── Load lịch sử đặt giá từ API ──────────────────────
        private async Task LoadHistory()
        {
            try
            {
                var history = await _api.GetHistory(_auction.Id);
                dgvHistory.Rows.Clear();
                foreach (var bid in history.OrderByDescending(b => b.BidTime))
                {
                    dgvHistory.Rows.Add(
                        bid.FullName,
                        bid.BidAmount.ToString("N0") + " đ",
                        bid.BidTime.ToString("HH:mm:ss")
                    );
                }
            }
            catch
            {
                // Không có lịch sử hoặc lỗi kết nối → bỏ qua
            }
        }

        // ── Đếm ngược thời gian ──────────────────────────────
        private void Timer1_Tick(object? sender, EventArgs e)
        {
            var remaining = _endTime - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                timer1.Stop();
                lblCountdown.Text = "Thời gian còn lại: ĐÃ KẾT THÚC";
                btnBid.Enabled = false;
            }
            else
            {
                lblCountdown.Text = $"Thời gian còn lại: {remaining:hh\\:mm\\:ss}";
            }
        }

        // ── Kết nối SignalR Hub ───────────────────────────────
        private async Task ConnectSignalR()
        {
            try
            {
                _hubConnection = new HubConnectionBuilder()
                    .WithUrl("https://localhost:5001/auctionHub")
                    .WithAutomaticReconnect()
                    .Build();

                // Nhận sự kiện: có người đặt giá mới
                _hubConnection.On<BidUpdatedDto>("BidUpdated", (data) =>
                {
                    if (data.AuctionId != _auction.Id) return;

                    // Phải dùng Invoke vì đây là luồng khác
                    this.Invoke(() =>
                    {
                        // Cập nhật giá hiện tại
                        lblCurrentPrice.Text = $"Giá hiện tại: {data.CurrentPrice:N0} đ";

                        // Thêm dòng mới lên đầu bảng lịch sử
                        dgvHistory.Rows.Insert(0,
                            data.NewBid.FullName,
                            data.NewBid.BidAmount.ToString("N0") + " đ",
                            data.NewBid.BidTime.ToString("HH:mm:ss")
                        );
                    });
                });

                // Nhận sự kiện: phiên đấu giá kết thúc
                _hubConnection.On<AuctionEndedDto>("AuctionEnded", (data) =>
                {
                    if (data.AuctionId != _auction.Id) return;

                    this.Invoke(() =>
                    {
                        timer1.Stop();
                        btnBid.Enabled = false;
                        lblCountdown.Text = "Thời gian còn lại: ĐÃ KẾT THÚC";

                        MessageBox.Show(
                            $"🏆 Phiên đấu giá kết thúc!\n" +
                            $"Người thắng: {data.WinnerName}\n" +
                            $"Giá cuối: {data.FinalPrice:N0} đ",
                            "Kết quả đấu giá",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    });
                });

                // Bắt đầu kết nối
                await _hubConnection.StartAsync();

                // Tham gia nhóm của phiên này
                await _hubConnection.InvokeAsync("JoinAuction", _auction.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không kết nối được SignalR!\n{ex.Message}\n\n" +
                    "Ứng dụng vẫn chạy nhưng không nhận được cập nhật real-time.",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
        }

        // ── Xử lý nút ĐẶT GIÁ ───────────────────────────────
        private async void BtnBid_Click(object? sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (!decimal.TryParse(txtBid.Text.Trim(), out decimal bidAmount))
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ (chỉ nhập số)!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra kết nối
            if (_hubConnection == null || _hubConnection.State != HubConnectionState.Connected)
            {
                MessageBox.Show("Mất kết nối Server. Vui lòng đóng và mở lại!",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                btnBid.Enabled = false;
                btnBid.Text = "Đang gửi...";

                // Gửi lệnh đặt giá lên Server qua SignalR
                await _hubConnection.InvokeAsync("PlaceBid",
                    _auction.Id,
                    Session.UserId,
                    bidAmount
                );

                txtBid.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đặt giá thất bại!\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBid.Enabled = true;
                btnBid.Text = "Đặt giá";
            }
        }

        // ── Đóng form → ngắt kết nối SignalR ─────────────────
        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            timer1.Stop();
            if (_hubConnection != null)
            {
                await _hubConnection.StopAsync();
                await _hubConnection.DisposeAsync();
            }
            base.OnFormClosing(e);
        }
    }
}