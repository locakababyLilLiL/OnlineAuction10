namespace AuctionClient.Forms
{
    partial class AuctionForm
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.btnBid = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblStartPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(413, 152);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(261, 45);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "💰Giá hiện tại : \r\n";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtBid
            // 
            this.txtBid.BackColor = System.Drawing.SystemColors.Window;
            this.txtBid.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBid.Location = new System.Drawing.Point(413, 245);
            this.txtBid.Multiline = true;
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(501, 53);
            this.txtBid.TabIndex = 3;
            this.txtBid.TextChanged += new System.EventHandler(this.txtBid_TextChanged);
            // 
            // btnBid
            // 
            this.btnBid.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBid.ForeColor = System.Drawing.Color.White;
            this.btnBid.Location = new System.Drawing.Point(413, 292);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(238, 51);
            this.btnBid.TabIndex = 4;
            this.btnBid.Text = "🔨 Đặt giá";
            this.btnBid.UseVisualStyleBackColor = false;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHistory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHistory.ForeColor = System.Drawing.Color.FloralWhite;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 32;
            this.lstHistory.Location = new System.Drawing.Point(1, 394);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(910, 256);
            this.lstHistory.TabIndex = 5;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblItem.Location = new System.Drawing.Point(414, 63);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(404, 45);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "📦 Item:____| ID:_              \r\n";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(686, 290);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(228, 51);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = " Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "🏷️ THÔNG TIN PHIÊN ĐẤU GIÁ\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(414, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "✍️ Nhập giá đấu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(-7, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(918, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "🕘 Lịch sử đấu giá                                                               " +
    "      ";
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(0, 63);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(407, 278);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 11;
            this.picItem.TabStop = false;
            this.picItem.Click += new System.EventHandler(this.picItem_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(762, 197);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(155, 45);
            this.lblCountdown.TabIndex = 12;
            this.lblCountdown.Text = "⏱ 05:00";
            // 
            // lblStartPrice
            // 
            this.lblStartPrice.AutoSize = true;
            this.lblStartPrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblStartPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPrice.ForeColor = System.Drawing.Color.Red;
            this.lblStartPrice.Location = new System.Drawing.Point(414, 108);
            this.lblStartPrice.Name = "lblStartPrice";
            this.lblStartPrice.Size = new System.Drawing.Size(291, 45);
            this.lblStartPrice.TabIndex = 13;
            this.lblStartPrice.Text = "📌Giá khởi điểm :";
            this.lblStartPrice.Click += new System.EventHandler(this.lblStartPrice_Click);
            // 
            // AuctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 642);
            this.Controls.Add(this.lblStartPrice);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.lblPrice);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AuctionForm";
            this.Text = "     AucationForm   ";
            this.Load += new System.EventHandler(this.AuctionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblStartPrice;
    }
}