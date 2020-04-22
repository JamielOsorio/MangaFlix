namespace MangaFlix
{
    partial class CheckTimeInOutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCheckInOut = new System.Windows.Forms.DataGridView();
            this.btnCloseCheckInOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheckInOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "di ko alam kung panel ba ilalagay dito pero dito ilalagay database (delete this) " +
    "{naglagay ako datagrif}";
            // 
            // dataGridCheckInOut
            // 
            this.dataGridCheckInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCheckInOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCheckInOut.Location = new System.Drawing.Point(130, 163);
            this.dataGridCheckInOut.Name = "dataGridCheckInOut";
            this.dataGridCheckInOut.RowHeadersWidth = 51;
            this.dataGridCheckInOut.RowTemplate.Height = 24;
            this.dataGridCheckInOut.Size = new System.Drawing.Size(521, 310);
            this.dataGridCheckInOut.TabIndex = 1;
            // 
            // btnCloseCheckInOut
            // 
            this.btnCloseCheckInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseCheckInOut.Location = new System.Drawing.Point(13, 615);
            this.btnCloseCheckInOut.Name = "btnCloseCheckInOut";
            this.btnCloseCheckInOut.Size = new System.Drawing.Size(75, 23);
            this.btnCloseCheckInOut.TabIndex = 2;
            this.btnCloseCheckInOut.Text = "Close";
            this.btnCloseCheckInOut.UseVisualStyleBackColor = true;
            this.btnCloseCheckInOut.Click += new System.EventHandler(this.btnCloseCheckInOut_Click);
            // 
            // CheckTimeInOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 650);
            this.Controls.Add(this.btnCloseCheckInOut);
            this.Controls.Add(this.dataGridCheckInOut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 0);
            this.Name = "CheckTimeInOutForm";
            this.Text = "CheckTimeInOutForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheckInOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCheckInOut;
        private System.Windows.Forms.Button btnCloseCheckInOut;
    }
}