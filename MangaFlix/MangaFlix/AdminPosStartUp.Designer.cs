namespace MangaFlix
{
    partial class AdminPosStartUp
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
            this.AdmMainSidePanel = new System.Windows.Forms.Panel();
            this.SubPanelManageSales = new System.Windows.Forms.Panel();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.btnReciepts = new System.Windows.Forms.Button();
            this.btnSellManga = new System.Windows.Forms.Button();
            this.btnManageSales = new System.Windows.Forms.Button();
            this.SubPanelManga = new System.Windows.Forms.Panel();
            this.btnRmvManga = new System.Windows.Forms.Button();
            this.btnAddManga = new System.Windows.Forms.Button();
            this.btnManga = new System.Windows.Forms.Button();
            this.SubpanelEmployee = new System.Windows.Forms.Panel();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnTimeInOut = new System.Windows.Forms.Button();
            this.btnRmvEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.AdminScreenPanel = new System.Windows.Forms.Panel();
            this.picboxlogoADMpos = new System.Windows.Forms.PictureBox();
            this.AdmMainSidePanel.SuspendLayout();
            this.SubPanelManageSales.SuspendLayout();
            this.SubPanelManga.SuspendLayout();
            this.SubpanelEmployee.SuspendLayout();
            this.AdminScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogoADMpos)).BeginInit();
            this.SuspendLayout();
            // 
            // AdmMainSidePanel
            // 
            this.AdmMainSidePanel.AutoScroll = true;
            this.AdmMainSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AdmMainSidePanel.Controls.Add(this.SubPanelManageSales);
            this.AdmMainSidePanel.Controls.Add(this.btnManageSales);
            this.AdmMainSidePanel.Controls.Add(this.SubPanelManga);
            this.AdmMainSidePanel.Controls.Add(this.btnManga);
            this.AdmMainSidePanel.Controls.Add(this.SubpanelEmployee);
            this.AdmMainSidePanel.Controls.Add(this.btnEmployees);
            this.AdmMainSidePanel.Controls.Add(this.panelLogo);
            this.AdmMainSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdmMainSidePanel.Location = new System.Drawing.Point(0, 0);
            this.AdmMainSidePanel.Name = "AdmMainSidePanel";
            this.AdmMainSidePanel.Size = new System.Drawing.Size(215, 603);
            this.AdmMainSidePanel.TabIndex = 1;
            // 
            // SubPanelManageSales
            // 
            this.SubPanelManageSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubPanelManageSales.Controls.Add(this.btnGenReport);
            this.SubPanelManageSales.Controls.Add(this.btnReciepts);
            this.SubPanelManageSales.Controls.Add(this.btnSellManga);
            this.SubPanelManageSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelManageSales.Location = new System.Drawing.Point(0, 541);
            this.SubPanelManageSales.Name = "SubPanelManageSales";
            this.SubPanelManageSales.Size = new System.Drawing.Size(194, 128);
            this.SubPanelManageSales.TabIndex = 7;
            // 
            // btnGenReport
            // 
            this.btnGenReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenReport.FlatAppearance.BorderSize = 0;
            this.btnGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenReport.Location = new System.Drawing.Point(0, 80);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(194, 40);
            this.btnGenReport.TabIndex = 2;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // btnReciepts
            // 
            this.btnReciepts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReciepts.FlatAppearance.BorderSize = 0;
            this.btnReciepts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciepts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReciepts.Location = new System.Drawing.Point(0, 40);
            this.btnReciepts.Name = "btnReciepts";
            this.btnReciepts.Size = new System.Drawing.Size(194, 40);
            this.btnReciepts.TabIndex = 1;
            this.btnReciepts.Text = "Receipts";
            this.btnReciepts.UseVisualStyleBackColor = true;
            this.btnReciepts.Click += new System.EventHandler(this.btnReciepts_Click);
            // 
            // btnSellManga
            // 
            this.btnSellManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellManga.FlatAppearance.BorderSize = 0;
            this.btnSellManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellManga.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSellManga.Location = new System.Drawing.Point(0, 0);
            this.btnSellManga.Name = "btnSellManga";
            this.btnSellManga.Size = new System.Drawing.Size(194, 40);
            this.btnSellManga.TabIndex = 0;
            this.btnSellManga.Text = "Sell Manga";
            this.btnSellManga.UseVisualStyleBackColor = true;
            this.btnSellManga.Click += new System.EventHandler(this.btnSellManga_Click);
            // 
            // btnManageSales
            // 
            this.btnManageSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageSales.FlatAppearance.BorderSize = 0;
            this.btnManageSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSales.Font = new System.Drawing.Font("Coolvetica Rg", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSales.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnManageSales.Location = new System.Drawing.Point(0, 487);
            this.btnManageSales.Name = "btnManageSales";
            this.btnManageSales.Size = new System.Drawing.Size(194, 54);
            this.btnManageSales.TabIndex = 6;
            this.btnManageSales.Text = "Manage Sales";
            this.btnManageSales.UseVisualStyleBackColor = true;
            this.btnManageSales.Click += new System.EventHandler(this.btnManageSales_Click);
            // 
            // SubPanelManga
            // 
            this.SubPanelManga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubPanelManga.Controls.Add(this.btnRmvManga);
            this.SubPanelManga.Controls.Add(this.btnAddManga);
            this.SubPanelManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelManga.Location = new System.Drawing.Point(0, 396);
            this.SubPanelManga.Name = "SubPanelManga";
            this.SubPanelManga.Size = new System.Drawing.Size(194, 91);
            this.SubPanelManga.TabIndex = 5;
            // 
            // btnRmvManga
            // 
            this.btnRmvManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRmvManga.FlatAppearance.BorderSize = 0;
            this.btnRmvManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvManga.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRmvManga.Location = new System.Drawing.Point(0, 40);
            this.btnRmvManga.Name = "btnRmvManga";
            this.btnRmvManga.Size = new System.Drawing.Size(194, 40);
            this.btnRmvManga.TabIndex = 1;
            this.btnRmvManga.Text = "Remove Manga/s";
            this.btnRmvManga.UseVisualStyleBackColor = true;
            this.btnRmvManga.Click += new System.EventHandler(this.btnRmvManga_Click);
            // 
            // btnAddManga
            // 
            this.btnAddManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddManga.FlatAppearance.BorderSize = 0;
            this.btnAddManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManga.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddManga.Location = new System.Drawing.Point(0, 0);
            this.btnAddManga.Name = "btnAddManga";
            this.btnAddManga.Size = new System.Drawing.Size(194, 40);
            this.btnAddManga.TabIndex = 0;
            this.btnAddManga.Text = "Add Manga/s";
            this.btnAddManga.UseVisualStyleBackColor = true;
            this.btnAddManga.Click += new System.EventHandler(this.btnAddManga_Click);
            // 
            // btnManga
            // 
            this.btnManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManga.FlatAppearance.BorderSize = 0;
            this.btnManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManga.Font = new System.Drawing.Font("Coolvetica Rg", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManga.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnManga.Location = new System.Drawing.Point(0, 342);
            this.btnManga.Name = "btnManga";
            this.btnManga.Size = new System.Drawing.Size(194, 54);
            this.btnManga.TabIndex = 4;
            this.btnManga.Text = "Manage Mangas";
            this.btnManga.UseVisualStyleBackColor = true;
            this.btnManga.Click += new System.EventHandler(this.btnManga_Click);
            // 
            // SubpanelEmployee
            // 
            this.SubpanelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubpanelEmployee.Controls.Add(this.btnSalary);
            this.SubpanelEmployee.Controls.Add(this.btnTimeInOut);
            this.SubpanelEmployee.Controls.Add(this.btnRmvEmp);
            this.SubpanelEmployee.Controls.Add(this.btnAddEmp);
            this.SubpanelEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubpanelEmployee.Location = new System.Drawing.Point(0, 171);
            this.SubpanelEmployee.Name = "SubpanelEmployee";
            this.SubpanelEmployee.Size = new System.Drawing.Size(194, 171);
            this.SubpanelEmployee.TabIndex = 3;
            // 
            // btnSalary
            // 
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalary.Location = new System.Drawing.Point(0, 120);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(194, 40);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnTimeInOut
            // 
            this.btnTimeInOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimeInOut.FlatAppearance.BorderSize = 0;
            this.btnTimeInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeInOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTimeInOut.Location = new System.Drawing.Point(0, 80);
            this.btnTimeInOut.Name = "btnTimeInOut";
            this.btnTimeInOut.Size = new System.Drawing.Size(194, 40);
            this.btnTimeInOut.TabIndex = 2;
            this.btnTimeInOut.Text = "Check Time In/Out";
            this.btnTimeInOut.UseVisualStyleBackColor = true;
            this.btnTimeInOut.Click += new System.EventHandler(this.btnTimeInOut_Click);
            // 
            // btnRmvEmp
            // 
            this.btnRmvEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRmvEmp.FlatAppearance.BorderSize = 0;
            this.btnRmvEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRmvEmp.Location = new System.Drawing.Point(0, 40);
            this.btnRmvEmp.Name = "btnRmvEmp";
            this.btnRmvEmp.Size = new System.Drawing.Size(194, 40);
            this.btnRmvEmp.TabIndex = 1;
            this.btnRmvEmp.Text = "Remove Employee/s";
            this.btnRmvEmp.UseVisualStyleBackColor = true;
            this.btnRmvEmp.Click += new System.EventHandler(this.btnRmvEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmp.FlatAppearance.BorderSize = 0;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddEmp.Location = new System.Drawing.Point(0, 0);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(194, 40);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "Add Employee/s";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Coolvetica Rg", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEmployees.Location = new System.Drawing.Point(0, 117);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(194, 54);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 117);
            this.panelLogo.TabIndex = 1;
            // 
            // AdminScreenPanel
            // 
            this.AdminScreenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminScreenPanel.Controls.Add(this.picboxlogoADMpos);
            this.AdminScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminScreenPanel.Location = new System.Drawing.Point(215, 0);
            this.AdminScreenPanel.Name = "AdminScreenPanel";
            this.AdminScreenPanel.Size = new System.Drawing.Size(767, 603);
            this.AdminScreenPanel.TabIndex = 2;
            // 
            // picboxlogoADMpos
            // 
            this.picboxlogoADMpos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxlogoADMpos.BackColor = System.Drawing.Color.Transparent;
            this.picboxlogoADMpos.Image = global::MangaFlix.Properties.Resources.MF_500x111_;
            this.picboxlogoADMpos.Location = new System.Drawing.Point(48, 251);
            this.picboxlogoADMpos.Name = "picboxlogoADMpos";
            this.picboxlogoADMpos.Size = new System.Drawing.Size(681, 120);
            this.picboxlogoADMpos.TabIndex = 0;
            this.picboxlogoADMpos.TabStop = false;
            // 
            // AdminPosStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.AdminScreenPanel);
            this.Controls.Add(this.AdmMainSidePanel);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "AdminPosStartUp";
            this.Text = "AdminPosStartUp";
            this.Load += new System.EventHandler(this.AdminPosStartUp_Load);
            this.AdmMainSidePanel.ResumeLayout(false);
            this.SubPanelManageSales.ResumeLayout(false);
            this.SubPanelManga.ResumeLayout(false);
            this.SubpanelEmployee.ResumeLayout(false);
            this.AdminScreenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogoADMpos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AdmMainSidePanel;
        private System.Windows.Forms.Panel SubpanelEmployee;
        private System.Windows.Forms.Button btnTimeInOut;
        private System.Windows.Forms.Button btnRmvEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel SubPanelManga;
        private System.Windows.Forms.Button btnRmvManga;
        private System.Windows.Forms.Button btnAddManga;
        private System.Windows.Forms.Button btnManga;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Panel SubPanelManageSales;
        private System.Windows.Forms.Button btnReciepts;
        private System.Windows.Forms.Button btnSellManga;
        private System.Windows.Forms.Button btnManageSales;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Panel AdminScreenPanel;
        private System.Windows.Forms.PictureBox picboxlogoADMpos;
    }
}