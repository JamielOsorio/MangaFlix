namespace MangaFlix
{
    partial class GenerateReportForm
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
            this.dataGridGenerateReport = new System.Windows.Forms.DataGridView();
            this.btnCloseGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenerateReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGenerateReport
            // 
            this.dataGridGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridGenerateReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGenerateReport.Location = new System.Drawing.Point(98, 49);
            this.dataGridGenerateReport.Name = "dataGridGenerateReport";
            this.dataGridGenerateReport.RowHeadersWidth = 51;
            this.dataGridGenerateReport.RowTemplate.Height = 24;
            this.dataGridGenerateReport.Size = new System.Drawing.Size(557, 381);
            this.dataGridGenerateReport.TabIndex = 0;
            // 
            // btnCloseGenerateReport
            // 
            this.btnCloseGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseGenerateReport.Location = new System.Drawing.Point(13, 568);
            this.btnCloseGenerateReport.Name = "btnCloseGenerateReport";
            this.btnCloseGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.btnCloseGenerateReport.TabIndex = 1;
            this.btnCloseGenerateReport.Text = "Close";
            this.btnCloseGenerateReport.UseVisualStyleBackColor = true;
            this.btnCloseGenerateReport.Click += new System.EventHandler(this.btnCloseGenerateReport_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "di ko alam kung paano mo gagawin dito";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ikaw nalang bahala mag add ng buttons";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "paki anchor nalang lahat ng object to all sides except sa close button";
            // 
            // GenerateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseGenerateReport);
            this.Controls.Add(this.dataGridGenerateReport);
            this.Location = new System.Drawing.Point(215, 0);
            this.Name = "GenerateReportForm";
            this.Text = "GenerateReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenerateReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGenerateReport;
        private System.Windows.Forms.Button btnCloseGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}