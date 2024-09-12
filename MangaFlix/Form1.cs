using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaFlix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string posUsername = txtUsername.Text;
            string posPassword = txtPassword.Text;

            if (posUsername == "Employee1" && posPassword == "adobo")
            {
                this.Hide();
                Thread.Sleep(2500);
                PosStartUp n = new PosStartUp();
                n.Show();
            }
            else if (posUsername == "Employee2" && posPassword == "menudo")
            {
                this.Hide();
                Thread.Sleep(2500);
                PosStartUp n = new PosStartUp();
                n.Show();
            }
            else if (posUsername == "admin" && posPassword == "admin")
            {
                this.Hide();
                Thread.Sleep(2500);
                AdminPosStartUp n = new AdminPosStartUp();
                n.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }

        private void MangaFlixie_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit MangaFlixie POS ?", "MangaFlixie POS", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
