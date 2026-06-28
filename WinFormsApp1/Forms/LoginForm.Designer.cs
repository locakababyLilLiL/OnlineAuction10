namespace WinFormsApp1.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(189, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(189, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(192, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập :";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(189, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(189, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(189, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(400, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(224, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(413, 260);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 35);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng ký";
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(777, 366);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Name = "LoginForm";
            Text = "Đăng nhập";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}