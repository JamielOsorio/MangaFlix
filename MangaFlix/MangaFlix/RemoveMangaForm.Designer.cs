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
            this.btnCloseRemoveManga = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRemoveEmployee = new System.Windows.Forms.DataGridView();
            this.btnRmvEmployeeRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseRemoveManga
            // 
            this.btnCloseRemoveManga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseRemoveManga.Location = new System.Drawing.Point(12, 615);
            this.btnCloseRemoveManga.Name = "btnCloseRemoveManga";
            this.btnCloseRemoveManga.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRemoveManga.TabIndex = 2;
            this.btnCloseRemoveManga.Text = "Close";
            this.btnCloseRemoveManga.UseVisualStyleBackColor = true;
            this.btnCloseRemoveManga.Click += new System.EventHandler(this.btnCloseRemoveManga_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(691, 220);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(69, 28);
            this.btnCopy.TabIndex = 23;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(543, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Title:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "MangaFlixie Manga List:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridRemoveEmployee
            // 
            this.dataGridRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRemoveEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemoveEmployee.Location = new System.Drawing.Point(25, 93);
            this.dataGridRemoveEmployee.Name = "dataGridRemoveEmployee";
            this.dataGridRemoveEmployee.RowHeadersWidth = 51;
            this.dataGridRemoveEmployee.RowTemplate.Height = 24;
            this.dataGridRemoveEmployee.Size = new System.Drawing.Size(445, 458);
            this.dataGridRemoveEmployee.TabIndex = 1;
            this.dataGridRemoveEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemoveEmployee_CellClick);
            this.dataGridRemoveEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemoveEmployee_CellContentClick);
            // 
            // btnRmvEmployeeRemove
            // 
            this.btnRmvEmployeeRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRmvEmployeeRemove.Location = new System.Drawing.Point(543, 413);
            this.btnRmvEmployeeRemove.Name = "btnRmvEmployeeRemove";
            this.btnRmvEmployeeRemove.Size = new System.Drawing.Size(114, 35);
            this.btnRmvEmployeeRemove.TabIndex = 22;
            this.btnRmvEmployeeRemove.Text = "Remove";
            this.btnRmvEmployeeRemove.UseVisualStyleBackColor = true;
            this.btnRmvEmployeeRemove.Click += new System.EventHandler(this.btnRmvEmployeeRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Genre:";
            // 
            // textBox2
            // 
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox2.Location = new System.Drawing.Point(543, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(142, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox4.Location = new System.Drawing.Point(543, 313);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(142, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox3.Location = new System.Drawing.Point(543, 285);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(142, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox5.Location = new System.Drawing.Point(543, 341);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(142, 22);
            this.textBox5.TabIndex = 20;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox6.Location = new System.Drawing.Point(543, 369);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(142, 22);
            this.textBox6.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Stock:";
            // 
            // RemoveMangaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 650);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRemoveEmployee);
            this.Controls.Add(this.btnRmvEmployeeRemove);
            this.Controls.Add(this.btnCloseRemoveManga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 0);
            this.Name = "RemoveMangaForm";
            this.Text = "RemoveMangaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoveEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseRemoveManga;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridRemoveEmployee;
        private System.Windows.Forms.Button btnRmvEmployeeRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}