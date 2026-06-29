namespace AuctionServer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblNguoi = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(230, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SERVER ĐẤU GIÁ";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 124);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(579, 196);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 326);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Khởi động Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(179, 326);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(129, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Dừng Server";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(62, 50);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(79, 16);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá hiện tại :";
            // 
            // lblNguoi
            // 
            this.lblNguoi.AutoSize = true;
            this.lblNguoi.Location = new System.Drawing.Point(62, 77);
            this.lblNguoi.Name = "lblNguoi";
            this.lblNguoi.Size = new System.Drawing.Size(135, 16);
            this.lblNguoi.TabIndex = 5;
            this.lblNguoi.Text = "Người đang dẫn đầu :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(230, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 16);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "5:00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(230, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 16);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "10000000";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(230, 77);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(56, 16);
            this.lblWinner.TabIndex = 8;
            this.lblWinner.Text = "Chưa có";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thời gian còn lại :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNguoi);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblNguoi;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

