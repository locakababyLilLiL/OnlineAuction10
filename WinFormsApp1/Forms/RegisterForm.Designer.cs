namespace WinFormsApp1.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnBack = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 19);
            label1.Name = "label1";
            label1.Size = new Size(350, 45);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 74);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 142);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 204);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 244);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 4;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(174, 102);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(350, 31);
            txtFullname.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(174, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 31);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 232);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 31);
            txtPassword.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(370, 278);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 8;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(200, 278);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 387);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnBack;
        private Button btnRegister;
    }
}