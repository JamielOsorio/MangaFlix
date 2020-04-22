namespace MangaFlix
{
    partial class RecieptsForm
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
            this.btnCloseReceipt = new System.Windows.Forms.Button();
            this.dataGridReciept = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReciept)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseReceipt
            // 
            this.btnCloseReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseReceipt.Location = new System.Drawing.Point(13, 615);
            this.btnCloseReceipt.Name = "btnCloseReceipt";
            this.btnCloseReceipt.Size = new System.Drawing.Size(75, 23);
            this.btnCloseReceipt.TabIndex = 0;
            this.btnCloseReceipt.Text = "Close";
            this.btnCloseReceipt.UseVisualStyleBackColor = true;
            this.btnCloseReceipt.Click += new System.EventHandler(this.btnCloseReceipt_Click);
            // 
            // dataGridReciept
            // 
            this.dataGridReciept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReciept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReciept.Location = new System.Drawing.Point(34, 12);
            this.dataGridReciept.Name = "dataGridReciept";
            this.dataGridReciept.RowHeadersWidth = 51;
            this.dataGridReciept.RowTemplate.Height = 24;
            this.dataGridReciept.Size = new System.Drawing.Size(730, 582);
            this.dataGridReciept.TabIndex = 1;
            // 
            // RecieptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 650);
            this.Controls.Add(this.dataGridReciept);
            this.Controls.Add(this.btnCloseReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 0);
            this.Name = "RecieptsForm";
            this.Text = "RecieptsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReciept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseReceipt;
        private System.Windows.Forms.DataGridView dataGridReciept;
    }
}