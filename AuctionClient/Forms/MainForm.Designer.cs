namespace AuctionClient.Forms
{
    partial class MainForm
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
            this.btnJoin = new System.Windows.Forms.Button();
            this.dgvAuctions = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuctions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(12, 46);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(92, 30);
            this.btnJoin.TabIndex = 0;
            this.btnJoin.Text = "Tham gia";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // dgvAuctions
            // 
            this.dgvAuctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuctions.Location = new System.Drawing.Point(12, 93);
            this.dgvAuctions.Name = "dgvAuctions";
            this.dgvAuctions.RowHeadersWidth = 62;
            this.dgvAuctions.RowTemplate.Height = 28;
            this.dgvAuctions.Size = new System.Drawing.Size(499, 345);
            this.dgvAuctions.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(193, 25);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Welcome: user123";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(409, 46);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dgvAuctions);
            this.Controls.Add(this.btnJoin);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.DataGridView dgvAuctions;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnBack;
    }
}