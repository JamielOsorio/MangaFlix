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
            if (txtNewEmpPassword.Text == txtConfirmPassword.Text)
            {
                MongoCRUD db = new MongoCRUD("MangaFlixie");
                db.InsertRecord("Employee/s", new Employee { Username = txtNewEmpUsername.Text, Password = txtNewEmpPassword.Text });
                MessageBox.Show("Congratulations! You are now officially a MangaFlexer!", "MangaFlixie POS", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Your Password does not match, Please try again.", "MangaFlixie POS");
            }
            
        }
    }
}
