namespace MangaFlix
{
    partial class RemoveEmployeeForm
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
            this.deletethis = new System.Windows.Forms.Label();
            this.btnRmvEmployeeRemove = new System.Windows.Forms.Button();
            this.dataGridRemoveEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseRemoveEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // deletethis
            // 
            this.deletethis.AutoSize = true;
            this.deletethis.Location = new System.Drawing.Point(46, 56);
            this.deletethis.Name = "deletethis";
            this.deletethis.Size = new System.Drawing.Size(551, 17);
            this.deletethis.TabIndex = 0;
            this.deletethis.Text = "So yeah, di ko alam kung maglalagay ako ng panel dito. basta dito ididisplay data" +
    "base";
            // 
            // btnRmvEmployeeRemove
            // 
            this.btnRmvEmployeeRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRmvEmployeeRemove.Location = new System.Drawing.Point(348, 401);
            this.btnRmvEmployeeRemove.Name = "btnRmvEmployeeRemove";
            this.btnRmvEmployeeRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRmvEmployeeRemove.TabIndex = 1;
            this.btnRmvEmployeeRemove.Text = "Remove";
            this.btnRmvEmployeeRemove.UseVisualStyleBackColor = true;
            // 
            // dataGridRemoveEmployee
            // 
            this.dataGridRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRemoveEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemoveEmployee.Location = new System.Drawing.Point(142, 169);
            this.dataGridRemoveEmployee.Name = "dataGridRemoveEmployee";
            this.dataGridRemoveEmployee.RowHeadersWidth = 51;
            this.dataGridRemoveEmployee.RowTemplate.Height = 24;
            this.dataGridRemoveEmployee.Size = new System.Drawing.Size(487, 185);
            this.dataGridRemoveEmployee.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = " (delete this) {naglagay ako ng datagridview, dito ata display ng database}";
            // 
            // btnCloseRemoveEmployee
            // 
            this.btnCloseRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseRemoveEmployee.Location = new System.Drawing.Point(13, 521);
            this.btnCloseRemoveEmployee.Name = "btnCloseRemoveEmployee";
            this.btnCloseRemoveEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRemoveEmployee.TabIndex = 4;
            this.btnCloseRemoveEmployee.Text = "Close";
            this.btnCloseRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnCloseRemoveEmployee.Click += new System.EventHandler(this.btnCloseRemoveEmployee_Click);
            // 
            // RemoveEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 556);
            this.Controls.Add(this.btnCloseRemoveEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRemoveEmployee);
            this.Controls.Add(this.btnRmvEmployeeRemove);
            this.Controls.Add(this.deletethis);
            this.Name = "RemoveEmployeeForm";
            this.Text = "RemoveEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deletethis;
        private System.Windows.Forms.Button btnRmvEmployeeRemove;
        private System.Windows.Forms.DataGridView dataGridRemoveEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseRemoveEmployee;
    }
}