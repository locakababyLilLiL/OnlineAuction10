using WinFormsApp1.Services;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ApiService _api = new ApiService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Đang đăng nhập...";

            try
            {
                var result = await _api.Login(username, password);
                if (result != null && result.Success)
                {
                    Session.UserId = result.UserId;
                    Session.Token = result.Token;
                    Session.FullName = result.FullName;
                    new ProductListForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không kết nối được Server!\n{ex.Message}", "Lỗi kết nối",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Đăng nhập";
            }
        }

        private void lblTitle_Click(object sender, EventArgs e) { }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }
    }
}