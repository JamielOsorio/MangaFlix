namespace MangaFlix
{
    partial class AddEmployeeForm
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
            this.txtNewEmpUsername = new System.Windows.Forms.TextBox();
            this.txtNewEmpPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblAddEmpUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddEmpConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCloseAddEmployeeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewEmpUsername
            // 
            this.txtNewEmpUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewEmpUsername.Location = new System.Drawing.Point(174, 196);
            this.txtNewEmpUsername.Name = "txtNewEmpUsername";
            this.txtNewEmpUsername.Size = new System.Drawing.Size(424, 22);
            this.txtNewEmpUsername.TabIndex = 0;
            // 
            // txtNewEmpPassword
            // 
            this.txtNewEmpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewEmpPassword.Location = new System.Drawing.Point(174, 269);
            this.txtNewEmpPassword.Name = "txtNewEmpPassword";
            this.txtNewEmpPassword.Size = new System.Drawing.Size(424, 22);
            this.txtNewEmpPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(252, 396);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 36);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblAddEmpUsername
            // 
            this.lblAddEmpUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEmpUsername.AutoSize = true;
            this.lblAddEmpUsername.Location = new System.Drawing.Point(174, 165);
            this.lblAddEmpUsername.Name = "lblAddEmpUsername";
            this.lblAddEmpUsername.Size = new System.Drawing.Size(119, 17);
            this.lblAddEmpUsername.TabIndex = 3;
            this.lblAddEmpUsername.Text = "Create Username";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Password";
            // 
            // lblAddEmpConfirmPassword
            // 
            this.lblAddEmpConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEmpConfirmPassword.AutoSize = true;
            this.lblAddEmpConfirmPassword.Location = new System.Drawing.Point(174, 309);
            this.lblAddEmpConfirmPassword.Name = "lblAddEmpConfirmPassword";
            this.lblAddEmpConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.lblAddEmpConfirmPassword.TabIndex = 6;
            this.lblAddEmpConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(177, 339);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(424, 22);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Location = new System.Drawing.Point(394, 396);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(107, 36);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnCloseAddEmployeeForm
            // 
            this.btnCloseAddEmployeeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseAddEmployeeForm.Location = new System.Drawing.Point(12, 615);
            this.btnCloseAddEmployeeForm.Name = "btnCloseAddEmployeeForm";
            this.btnCloseAddEmployeeForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAddEmployeeForm.TabIndex = 8;
            this.btnCloseAddEmployeeForm.Text = "Close";
            this.btnCloseAddEmployeeForm.UseVisualStyleBackColor = true;
            this.btnCloseAddEmployeeForm.Click += new System.EventHandler(this.btnCloseAddEmployeeForm_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 650);
            this.Controls.Add(this.btnCloseAddEmployeeForm);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblAddEmpConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddEmpUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtNewEmpPassword);
            this.Controls.Add(this.txtNewEmpUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 0);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewEmpUsername;
        private System.Windows.Forms.TextBox txtNewEmpPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblAddEmpUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddEmpConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCloseAddEmployeeForm;
    }
}