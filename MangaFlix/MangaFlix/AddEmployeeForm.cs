using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaFlix
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCloseAddEmployeeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MongoCRUD db = new MongoCRUD("MangaFlixie");
            //string nullchecker = txtNewEmpPassword.Text
            if ((txtNewEmpPassword.Text != "")&&(txtNewEmpPassword.Text == txtConfirmPassword.Text))
            {
                db.InsertRecord("Employees", new Employee { username = txtNewEmpUsername.Text, password = txtNewEmpPassword.Text });
                MessageBox.Show("Congratulations! You are now officially a MangaFlexer!", "MangaFlixie POS", MessageBoxButtons.OK);
            }

            else if ( txtNewEmpPassword.Text == "" || txtConfirmPassword.Text== "" || txtNewEmpUsername.Text== "" )
            {
                MessageBox.Show("Please fill out the missing informations.", "MangaFlixie POS");
            }
            
            else
            {
                MessageBox.Show("Your Password does not match, Please try again.", "MangaFlixie POS");
            }
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtNewEmpUsername.Text = "";
            txtNewEmpPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
