namespace MangaFlix
{
    partial class PosStartUp
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.subpanel_MngInv = new System.Windows.Forms.Panel();
            this.btn_AddManga = new System.Windows.Forms.Button();
            this.btnMng_Manga = new System.Windows.Forms.Button();
            this.subpanel_MngSales = new System.Windows.Forms.Panel();
            this.btn_Receipts = new System.Windows.Forms.Button();
            this.btn_SellManga = new System.Windows.Forms.Button();
            this.btnMng_Sales = new System.Windows.Forms.Button();
            this.btn_RmvManga = new System.Windows.Forms.Button();
            this.ChildFormContainer = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.MFpicbox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.subpanel_MngInv.SuspendLayout();
            this.subpanel_MngSales.SuspendLayout();
            this.ChildFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MFpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.AutoScroll = true;
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TopPanel.Controls.Add(this.subpanel_MngInv);
            this.TopPanel.Controls.Add(this.btnMng_Manga);
            this.TopPanel.Controls.Add(this.subpanel_MngSales);
            this.TopPanel.Controls.Add(this.btnMng_Sales);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 62);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // subpanel_MngInv
            // 
            this.subpanel_MngInv.Controls.Add(this.btn_RmvManga);
            this.subpanel_MngInv.Controls.Add(this.btn_AddManga);
            this.subpanel_MngInv.Dock = System.Windows.Forms.DockStyle.Left;
            this.subpanel_MngInv.Location = new System.Drawing.Point(792, 0);
            this.subpanel_MngInv.Name = "subpanel_MngInv";
            this.subpanel_MngInv.Size = new System.Drawing.Size(287, 41);
            this.subpanel_MngInv.TabIndex = 7;
            // 
            // btn_AddManga
            // 
            this.btn_AddManga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(54)))));
            this.btn_AddManga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddManga.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_AddManga.FlatAppearance.BorderSize = 0;
            this.btn_AddManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddManga.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AddManga.Location = new System.Drawing.Point(0, 0);
            this.btn_AddManga.Name = "btn_AddManga";
            this.btn_AddManga.Size = new System.Drawing.Size(114, 41);
            this.btn_AddManga.TabIndex = 2;
            this.btn_AddManga.Text = "Add Manga/s";
            this.btn_AddManga.UseVisualStyleBackColor = false;
            this.btn_AddManga.Click += new System.EventHandler(this.btn_AddManga_Click);
            // 
            // btnMng_Manga
            // 
            this.btnMng_Manga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnMng_Manga.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMng_Manga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMng_Manga.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMng_Manga.Location = new System.Drawing.Point(622, 0);
            this.btnMng_Manga.Name = "btnMng_Manga";
            this.btnMng_Manga.Size = new System.Drawing.Size(170, 41);
            this.btnMng_Manga.TabIndex = 6;
            this.btnMng_Manga.Text = "Manage Inventory";
            this.btnMng_Manga.UseVisualStyleBackColor = true;
            this.btnMng_Manga.Click += new System.EventHandler(this.btnMng_Manga_Click_1);
            // 
            // subpanel_MngSales
            // 
            this.subpanel_MngSales.Controls.Add(this.btnGenReport);
            this.subpanel_MngSales.Controls.Add(this.btn_Receipts);
            this.subpanel_MngSales.Controls.Add(this.btn_SellManga);
            this.subpanel_MngSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.subpanel_MngSales.Location = new System.Drawing.Point(270, 0);
            this.subpanel_MngSales.Name = "subpanel_MngSales";
            this.subpanel_MngSales.Size = new System.Drawing.Size(352, 41);
            this.subpanel_MngSales.TabIndex = 5;
            // 
            // btn_Receipts
            // 
            this.btn_Receipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Receipts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Receipts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Receipts.FlatAppearance.BorderSize = 0;
            this.btn_Receipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Receipts.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Receipts.Location = new System.Drawing.Point(114, 0);
            this.btn_Receipts.Name = "btn_Receipts";
            this.btn_Receipts.Size = new System.Drawing.Size(114, 41);
            this.btn_Receipts.TabIndex = 2;
            this.btn_Receipts.Text = "Reciepts";
            this.btn_Receipts.UseVisualStyleBackColor = false;
            this.btn_Receipts.Click += new System.EventHandler(this.btn_Receipts_Click);
            // 
            // btn_SellManga
            // 
            this.btn_SellManga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(54)))));
            this.btn_SellManga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SellManga.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SellManga.FlatAppearance.BorderSize = 0;
            this.btn_SellManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SellManga.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SellManga.Location = new System.Drawing.Point(0, 0);
            this.btn_SellManga.Name = "btn_SellManga";
            this.btn_SellManga.Size = new System.Drawing.Size(114, 41);
            this.btn_SellManga.TabIndex = 1;
            this.btn_SellManga.Text = "Sell Manga";
            this.btn_SellManga.UseVisualStyleBackColor = false;
            this.btn_SellManga.Click += new System.EventHandler(this.btn_SellManga_Click);
            // 
            // btnMng_Sales
            // 
            this.btnMng_Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnMng_Sales.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMng_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMng_Sales.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMng_Sales.Location = new System.Drawing.Point(100, 0);
            this.btnMng_Sales.Name = "btnMng_Sales";
            this.btnMng_Sales.Size = new System.Drawing.Size(170, 41);
            this.btnMng_Sales.TabIndex = 3;
            this.btnMng_Sales.Text = "Manage Sales";
            this.btnMng_Sales.UseVisualStyleBackColor = true;
            this.btnMng_Sales.Click += new System.EventHandler(this.btnMng_Sales_Click_1);
            // 
            // btn_RmvManga
            // 
            this.btn_RmvManga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_RmvManga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RmvManga.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_RmvManga.FlatAppearance.BorderSize = 0;
            this.btn_RmvManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RmvManga.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_RmvManga.Location = new System.Drawing.Point(114, 0);
            this.btn_RmvManga.Name = "btn_RmvManga";
            this.btn_RmvManga.Size = new System.Drawing.Size(114, 41);
            this.btn_RmvManga.TabIndex = 4;
            this.btn_RmvManga.Text = "Remove Manga/s";
            this.btn_RmvManga.UseVisualStyleBackColor = false;
            this.btn_RmvManga.Click += new System.EventHandler(this.btn_RmvManga_Click);
            // 
            // ChildFormContainer
            // 
            this.ChildFormContainer.BackgroundImage = global::MangaFlix.Properties.Resources._70854301_p3;
            this.ChildFormContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChildFormContainer.Controls.Add(this.btn_logout);
            this.ChildFormContainer.Controls.Add(this.MFpicbox);
            this.ChildFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormContainer.Location = new System.Drawing.Point(0, 62);
            this.ChildFormContainer.Name = "ChildFormContainer";
            this.ChildFormContainer.Size = new System.Drawing.Size(1000, 588);
            this.ChildFormContainer.TabIndex = 1;
            this.ChildFormContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildFormContainer_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(12, 553);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(66, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MFpicbox
            // 
            this.MFpicbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MFpicbox.BackColor = System.Drawing.Color.Transparent;
            this.MFpicbox.Image = global::MangaFlix.Properties.Resources.MF_500x111_;
            this.MFpicbox.InitialImage = null;
            this.MFpicbox.Location = new System.Drawing.Point(167, 168);
            this.MFpicbox.Name = "MFpicbox";
            this.MFpicbox.Size = new System.Drawing.Size(707, 165);
            this.MFpicbox.TabIndex = 0;
            this.MFpicbox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 41);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenReport
            // 
            this.btnGenReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnGenReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenReport.FlatAppearance.BorderSize = 0;
            this.btnGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenReport.Location = new System.Drawing.Point(228, 0);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(114, 41);
            this.btnGenReport.TabIndex = 5;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = false;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // PosStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.ChildFormContainer);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PosStartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PosStartUp_Load);
            this.TopPanel.ResumeLayout(false);
            this.subpanel_MngInv.ResumeLayout(false);
            this.subpanel_MngSales.ResumeLayout(false);
            this.ChildFormContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MFpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ChildFormContainer;
        private System.Windows.Forms.PictureBox MFpicbox;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel subpanel_MngSales;
        private System.Windows.Forms.Button btnMng_Sales;
        private System.Windows.Forms.Button btn_Receipts;
        private System.Windows.Forms.Button btn_SellManga;
        private System.Windows.Forms.Button btnMng_Manga;
        private System.Windows.Forms.Panel subpanel_MngInv;
        private System.Windows.Forms.Button btn_AddManga;
        private System.Windows.Forms.Button btn_RmvManga;
        private System.Windows.Forms.Button btnGenReport;
    }
}