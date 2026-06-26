namespace WinFormsApp1.Utils
{
    partial class AuctionDetailForm
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
            components = new System.ComponentModel.Container();
            picProduct = new PictureBox();
            lblTitle = new Label();
            lblCurrentPrice = new Label();
            lblCountdown = new Label();
            label1 = new Label();
            txtBid = new TextBox();
            btnBid = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvHistory = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // picProduct
            // 
            picProduct.Location = new Point(29, 47);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(462, 250);
            picProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(29, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(117, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Đêm đầy sao";
            // 
            // lblCurrentPrice
            // 
            lblCurrentPrice.AutoSize = true;
            lblCurrentPrice.Location = new Point(29, 300);
            lblCurrentPrice.Name = "lblCurrentPrice";
            lblCurrentPrice.Size = new Size(193, 25);
            lblCurrentPrice.TabIndex = 2;
            lblCurrentPrice.Text = "Giá hiện tại : 5000000$";
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Location = new Point(29, 339);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(223, 25);
            lblCountdown.TabIndex = 3;
            lblCountdown.Text = "Thời gian còn lại : 00:10:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 385);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 4;
            label1.Text = "Giá muốn đặt :";
            // 
            // txtBid
            // 
            txtBid.Location = new Point(164, 382);
            txtBid.Name = "txtBid";
            txtBid.Size = new Size(209, 31);
            txtBid.TabIndex = 5;
            // 
            // btnBid
            // 
            btnBid.Location = new Point(379, 385);
            btnBid.Name = "btnBid";
            btnBid.Size = new Size(112, 34);
            btnBid.TabIndex = 6;
            btnBid.Text = "Đặt giá";
            btnBid.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(550, 32);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(272, 378);
            dgvHistory.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 300);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 9;
            label2.Text = "Bước giá : 1000$";
            // 
            // AuctionDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 464);
            Controls.Add(label2);
            Controls.Add(dgvHistory);
            Controls.Add(btnBid);
            Controls.Add(txtBid);
            Controls.Add(label1);
            Controls.Add(lblCountdown);
            Controls.Add(lblCurrentPrice);
            Controls.Add(lblTitle);
            Controls.Add(picProduct);
            Name = "AuctionDetailForm";
            Text = "AuctionDetailForm";
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProduct;
        private Label lblTitle;
        private Label lblCurrentPrice;
        private Label lblCountdown;
        private Label label1;
        private TextBox txtBid;
        private Button btnBid;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvHistory;
        private Label label2;
    }
}