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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(3, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(291, 48);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "💰Giá hiện tại : \r\n";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtBid
            // 
            this.txtBid.BackColor = System.Drawing.SystemColors.Window;
            this.txtBid.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBid.Location = new System.Drawing.Point(0, 263);
            this.txtBid.Multiline = true;
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(382, 53);
            this.txtBid.TabIndex = 3;
            this.txtBid.TextChanged += new System.EventHandler(this.txtBid_TextChanged);
            // 
            // btnBid
            // 
            this.btnBid.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBid.ForeColor = System.Drawing.Color.White;
            this.btnBid.Location = new System.Drawing.Point(382, 263);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(185, 53);
            this.btnBid.TabIndex = 4;
            this.btnBid.Text = "🔨 Đặt giá";
            this.btnBid.UseVisualStyleBackColor = false;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lstHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHistory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHistory.ForeColor = System.Drawing.Color.Blue;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 32;
            this.lstHistory.Location = new System.Drawing.Point(-3, 433);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(1063, 256);
            this.lstHistory.TabIndex = 5;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Red;
            this.lblItem.Location = new System.Drawing.Point(3, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(467, 48);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "📦 Item:____| ID:__              \r\n";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(385, 215);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 47);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = " Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "🏷️ THÔNG TIN PHIÊN ĐẤU GIÁ\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(3, 217);
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
            this.label3.Location = new System.Drawing.Point(-4, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1071, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "🕘 Lịch sử đấu giá                                                               " +
    "                       ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(-6, 65);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(490, 317);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 11;
            this.picItem.TabStop = false;
            this.picItem.Click += new System.EventHandler(this.picItem_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(3, 48);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(174, 48);
            this.lblCountdown.TabIndex = 12;
            this.lblCountdown.Text = "⏱ 05:00";
            // 
            // lblStartPrice
            // 
            this.lblStartPrice.AutoSize = true;
            this.lblStartPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblStartPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPrice.ForeColor = System.Drawing.Color.Red;
            this.lblStartPrice.Location = new System.Drawing.Point(6, 96);
            this.lblStartPrice.Name = "lblStartPrice";
            this.lblStartPrice.Size = new System.Drawing.Size(325, 48);
            this.lblStartPrice.TabIndex = 13;
            this.lblStartPrice.Text = "📌Giá khởi điểm :";
            this.lblStartPrice.Click += new System.EventHandler(this.lblStartPrice_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 64);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblCountdown);
            this.panel2.Controls.Add(this.lblStartPrice);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblItem);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.txtBid);
            this.panel2.Controls.Add(this.btnBid);
            this.panel2.Location = new System.Drawing.Point(490, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 316);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AuctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHistory);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AuctionForm";
            this.Text = "     AucationForm   ";
            this.Load += new System.EventHandler(this.AuctionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}