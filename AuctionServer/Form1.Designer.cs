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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStartTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblCurrentTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinnerTitle = new System.Windows.Forms.Label();
            this.panelLog = new System.Windows.Forms.Panel();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStartPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPauseTime = new System.Windows.Forms.Button();
            this.btnResumeTime = new System.Windows.Forms.Button();
            this.pnlSummary.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(2, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(605, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔴  LIVE AUCTION SERVER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlSummary.Controls.Add(this.panel5);
            this.pnlSummary.Controls.Add(this.panel1);
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Location = new System.Drawing.Point(6, 98);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(391, 408);
            this.pnlSummary.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblPrice);
            this.panel5.Controls.Add(this.lblStartTitle);
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(0, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 67);
            this.panel5.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 63);
            this.label2.TabIndex = 10;
            this.label2.Text = "🏷️";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrice.Location = new System.Drawing.Point(98, 28);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 39);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "0$";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblStartTitle
            // 
            this.lblStartTitle.AutoSize = true;
            this.lblStartTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStartTitle.Location = new System.Drawing.Point(97, 0);
            this.lblStartTitle.Name = "lblStartTitle";
            this.lblStartTitle.Size = new System.Drawing.Size(154, 29);
            this.lblStartTitle.TabIndex = 9;
            this.lblStartTitle.Text = "Giá khởi điểm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProductTitle);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 65);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "📦";
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductTitle.Location = new System.Drawing.Point(99, 0);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(112, 29);
            this.lblProductTitle.TabIndex = 7;
            this.lblProductTitle.Text = "Sản phẩm";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProduct.ForeColor = System.Drawing.Color.Yellow;
            this.lblProduct.Location = new System.Drawing.Point(95, 24);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(216, 39);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Đồng hồ CASIO\r\n";
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblSummaryTitle.Location = new System.Drawing.Point(3, 4);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(294, 32);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "📊 AUCTION SUMMARY";
            // 
            // lblCurrentTitle
            // 
            this.lblCurrentTitle.AutoSize = true;
            this.lblCurrentTitle.BackColor = System.Drawing.Color.Firebrick;
            this.lblCurrentTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCurrentTitle.Location = new System.Drawing.Point(97, 0);
            this.lblCurrentTitle.Name = "lblCurrentTitle";
            this.lblCurrentTitle.Size = new System.Drawing.Size(126, 29);
            this.lblCurrentTitle.TabIndex = 1;
            this.lblCurrentTitle.Text = "Giá hiện tại";
            this.lblCurrentTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblTime.Location = new System.Drawing.Point(95, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(90, 39);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "05:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(97, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time remaining";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblWinner.Location = new System.Drawing.Point(98, 25);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(125, 39);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "Chưa có";
            this.lblWinner.Click += new System.EventHandler(this.lblWinner_Click);
            // 
            // lblWinnerTitle
            // 
            this.lblWinnerTitle.AutoSize = true;
            this.lblWinnerTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWinnerTitle.Location = new System.Drawing.Point(99, 0);
            this.lblWinnerTitle.Name = "lblWinnerTitle";
            this.lblWinnerTitle.Size = new System.Drawing.Size(93, 29);
            this.lblWinnerTitle.TabIndex = 3;
            this.lblWinnerTitle.Text = "Winner ";
            this.lblWinnerTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelLog.Controls.Add(this.rtbLog);
            this.panelLog.Controls.Add(this.label5);
            this.panelLog.Location = new System.Drawing.Point(403, 98);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(609, 408);
            this.panelLog.TabIndex = 0;
            this.panelLog.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLog_Paint);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.Black;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.ForeColor = System.Drawing.Color.Lime;
            this.rtbLog.Location = new System.Drawing.Point(0, 48);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(609, 360);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 48);
            this.label5.TabIndex = 0;
            this.label5.Text = "📜 Live Log";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(655, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 53);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "▶ Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(832, 23);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(180, 53);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "■ Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStartPrice
            // 
            this.lblStartPrice.AutoSize = true;
            this.lblStartPrice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStartPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblStartPrice.Location = new System.Drawing.Point(98, 22);
            this.lblStartPrice.Name = "lblStartPrice";
            this.lblStartPrice.Size = new System.Drawing.Size(125, 39);
            this.lblStartPrice.TabIndex = 10;
            this.lblStartPrice.Text = "Chưa có";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.btnResumeTime);
            this.panel2.Controls.Add(this.btnPauseTime);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(6, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 67);
            this.panel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(-2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 63);
            this.label8.TabIndex = 7;
            this.label8.Text = "⏱";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblWinnerTitle);
            this.panel3.Controls.Add(this.lblWinner);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(6, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 67);
            this.panel3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 64);
            this.label7.TabIndex = 5;
            this.label7.Text = "👑";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblCurrentTitle);
            this.panel4.Controls.Add(this.lblStartPrice);
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(6, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 67);
            this.panel4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 63);
            this.label3.TabIndex = 15;
            this.label3.Text = "💰";
            // 
            // btnPauseTime
            // 
            this.btnPauseTime.BackColor = System.Drawing.Color.Red;
            this.btnPauseTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPauseTime.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPauseTime.ForeColor = System.Drawing.Color.White;
            this.btnPauseTime.Location = new System.Drawing.Point(337, 37);
            this.btnPauseTime.Name = "btnPauseTime";
            this.btnPauseTime.Size = new System.Drawing.Size(41, 30);
            this.btnPauseTime.TabIndex = 15;
            this.btnPauseTime.Text = "⏸";
            this.btnPauseTime.UseVisualStyleBackColor = false;
            this.btnPauseTime.Click += new System.EventHandler(this.btnPauseTime_Click);
            // 
            // btnResumeTime
            // 
            this.btnResumeTime.BackColor = System.Drawing.Color.LimeGreen;
            this.btnResumeTime.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnResumeTime.ForeColor = System.Drawing.SystemColors.Window;
            this.btnResumeTime.Location = new System.Drawing.Point(335, -2);
            this.btnResumeTime.Name = "btnResumeTime";
            this.btnResumeTime.Size = new System.Drawing.Size(43, 31);
            this.btnResumeTime.TabIndex = 16;
            this.btnResumeTime.Text = "▶";
            this.btnResumeTime.UseVisualStyleBackColor = false;
            this.btnResumeTime.Click += new System.EventHandler(this.btnResumeTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1038, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Auction Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblWinnerTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStartTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStartPrice;
        private System.Windows.Forms.Label lblCurrentTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResumeTime;
        private System.Windows.Forms.Button btnPauseTime;
    }
}

