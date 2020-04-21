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
            this.btnRmvEmployeeRemove = new System.Windows.Forms.Button();
            this.dataGridRemoveEmployee = new System.Windows.Forms.DataGridView();
            this.btnCloseRemoveEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRmvEmployeeRemove
            // 
            this.btnRmvEmployeeRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRmvEmployeeRemove.Location = new System.Drawing.Point(567, 307);
            this.btnRmvEmployeeRemove.Name = "btnRmvEmployeeRemove";
            this.btnRmvEmployeeRemove.Size = new System.Drawing.Size(114, 35);
            this.btnRmvEmployeeRemove.TabIndex = 3;
            this.btnRmvEmployeeRemove.Text = "Remove";
            this.btnRmvEmployeeRemove.UseVisualStyleBackColor = true;
            this.btnRmvEmployeeRemove.Click += new System.EventHandler(this.btnRmvEmployeeRemove_Click);
            // 
            // dataGridRemoveEmployee
            // 
            this.dataGridRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRemoveEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemoveEmployee.Location = new System.Drawing.Point(49, 90);
            this.dataGridRemoveEmployee.Name = "dataGridRemoveEmployee";
            this.dataGridRemoveEmployee.RowHeadersWidth = 51;
            this.dataGridRemoveEmployee.RowTemplate.Height = 24;
            this.dataGridRemoveEmployee.Size = new System.Drawing.Size(445, 458);
            this.dataGridRemoveEmployee.TabIndex = 2;
            this.dataGridRemoveEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemoveEmployee_CellClick);
            this.dataGridRemoveEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemoveEmployee_CellContentClick);
            // 
            // btnCloseRemoveEmployee
            // 
            this.btnCloseRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseRemoveEmployee.Location = new System.Drawing.Point(13, 615);
            this.btnCloseRemoveEmployee.Name = "btnCloseRemoveEmployee";
            this.btnCloseRemoveEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRemoveEmployee.TabIndex = 4;
            this.btnCloseRemoveEmployee.Text = "Close";
            this.btnCloseRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnCloseRemoveEmployee.Click += new System.EventHandler(this.btnCloseRemoveEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "MangaFlixie Employee List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "I.D.:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(567, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(567, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(142, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(715, 193);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(69, 28);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.TabStop = false;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // RemoveEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 650);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseRemoveEmployee);
            this.Controls.Add(this.dataGridRemoveEmployee);
            this.Controls.Add(this.btnRmvEmployeeRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 0);
            this.Name = "RemoveEmployeeForm";
            this.Text = "RemoveEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRmvEmployeeRemove;
        private System.Windows.Forms.DataGridView dataGridRemoveEmployee;
        private System.Windows.Forms.Button btnCloseRemoveEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCopy;
    }
}