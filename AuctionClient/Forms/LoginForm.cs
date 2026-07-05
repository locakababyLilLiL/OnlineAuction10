using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionClient.Forms
{
    public partial class LoginForm : Form
    {
        public static string CurrentUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ!");
                return;
            }

            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 9999))
                {
                    NetworkStream stream = client.GetStream();

                    string msg = "LOGIN|" + txtUsername.Text + "|" + txtPassword.Text;
                    byte[] data = Encoding.UTF8.GetBytes(msg);
                    stream.Write(data, 0, data.Length);

                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytes);

                    if (response.StartsWith("LOGIN_OK"))
                    {
                        CurrentUser = txtUsername.Text;

                        MainForm f = new MainForm();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(response.Replace("ERROR|", ""));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được Server. Hãy bấm Start bên Server trước.\n" + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
