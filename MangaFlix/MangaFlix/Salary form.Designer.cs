namespace MangaFlix
{
    partial class Salary_form
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
            this.dataGridSalary = new System.Windows.Forms.DataGridView();
            this.btnCloseSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSalary
            // 
            this.dataGridSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalary.Location = new System.Drawing.Point(116, 54);
            this.dataGridSalary.Name = "dataGridSalary";
            this.dataGridSalary.RowHeadersWidth = 51;
            this.dataGridSalary.RowTemplate.Height = 24;
            this.dataGridSalary.Size = new System.Drawing.Size(506, 314);
            this.dataGridSalary.TabIndex = 0;
            // 
            // btnCloseSalary
            // 
            this.btnCloseSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseSalary.Location = new System.Drawing.Point(22, 521);
            this.btnCloseSalary.Name = "btnCloseSalary";
            this.btnCloseSalary.Size = new System.Drawing.Size(75, 23);
            this.btnCloseSalary.TabIndex = 1;
            this.btnCloseSalary.Text = "Close";
            this.btnCloseSalary.UseVisualStyleBackColor = true;
            this.btnCloseSalary.Click += new System.EventHandler(this.btnCloseSalary_Click);
            // 
            // Salary_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 556);
            this.Controls.Add(this.btnCloseSalary);
            this.Controls.Add(this.dataGridSalary);
            this.Name = "Salary_form";
            this.Text = "Salary_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSalary;
        private System.Windows.Forms.Button btnCloseSalary;
    }
}