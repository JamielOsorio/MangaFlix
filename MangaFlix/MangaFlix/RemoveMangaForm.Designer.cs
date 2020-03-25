namespace MangaFlix
{
    partial class RemoveMangaForm
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
            this.dataGridRemoveManga = new System.Windows.Forms.DataGridView();
            this.btnRemoveRM = new System.Windows.Forms.Button();
            this.btnCloseRemoveManga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveManga)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRemoveManga
            // 
            this.dataGridRemoveManga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRemoveManga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemoveManga.Location = new System.Drawing.Point(42, 46);
            this.dataGridRemoveManga.Name = "dataGridRemoveManga";
            this.dataGridRemoveManga.RowHeadersWidth = 51;
            this.dataGridRemoveManga.RowTemplate.Height = 24;
            this.dataGridRemoveManga.Size = new System.Drawing.Size(653, 306);
            this.dataGridRemoveManga.TabIndex = 0;
            // 
            // btnRemoveRM
            // 
            this.btnRemoveRM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveRM.Location = new System.Drawing.Point(331, 377);
            this.btnRemoveRM.Name = "btnRemoveRM";
            this.btnRemoveRM.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRM.TabIndex = 1;
            this.btnRemoveRM.Text = "Remove";
            this.btnRemoveRM.UseVisualStyleBackColor = true;
            // 
            // btnCloseRemoveManga
            // 
            this.btnCloseRemoveManga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseRemoveManga.Location = new System.Drawing.Point(12, 521);
            this.btnCloseRemoveManga.Name = "btnCloseRemoveManga";
            this.btnCloseRemoveManga.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRemoveManga.TabIndex = 2;
            this.btnCloseRemoveManga.Text = "Close";
            this.btnCloseRemoveManga.UseVisualStyleBackColor = true;
            this.btnCloseRemoveManga.Click += new System.EventHandler(this.btnCloseRemoveManga_Click);
            // 
            // RemoveMangaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 556);
            this.Controls.Add(this.btnCloseRemoveManga);
            this.Controls.Add(this.btnRemoveRM);
            this.Controls.Add(this.dataGridRemoveManga);
            this.Name = "RemoveMangaForm";
            this.Text = "RemoveMangaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveManga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRemoveManga;
        private System.Windows.Forms.Button btnRemoveRM;
        private System.Windows.Forms.Button btnCloseRemoveManga;
    }
}