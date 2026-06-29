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
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(28, 156);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(219, 20);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Giá hiện tại : 10 000 000 VNĐ";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(32, 224);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(346, 26);
            this.txtBid.TabIndex = 3;
            // 
            // btnBid
            // 
            this.btnBid.Location = new System.Drawing.Point(396, 222);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(100, 30);
            this.btnBid.TabIndex = 4;
            this.btnBid.Text = "Đặt giá";
            this.btnBid.UseVisualStyleBackColor = true;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(12, 271);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(555, 184);
            this.lstHistory.TabIndex = 5;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(28, 114);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(146, 20);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "Item: Laptop | ID: 1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(396, 114);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN PHIÊN ĐẤU GIÁ\r\n";
            // 
            // AuctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.lblPrice);
            this.Name = "AuctionForm";
            this.Text = "AuctionForm";
            this.Load += new System.EventHandler(this.AuctionForm_Load);
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
    }
}