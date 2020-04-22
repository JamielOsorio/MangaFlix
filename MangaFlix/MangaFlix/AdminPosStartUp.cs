using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace MangaFlix
{
    public partial class AdminPosStartUp : Form
    {
        public AdminPosStartUp()
        {
            InitializeComponent();
            subpanelspopup();
        }
        private void subpanelspopup()
        {
            //hide all subpanels
            SubpanelEmployee.Visible = false;
            SubPanelManga.Visible = false;
            SubPanelManageSales.Visible = false;

        }
        private void hidesubpanels()
        {
            //hide subpanels when a main category is clicked
            if (SubpanelEmployee.Visible == true)
                SubpanelEmployee.Visible = false;
            if (SubPanelManga.Visible == true)
                SubPanelManga.Visible = false;
            if (SubPanelManageSales.Visible == true)
                SubPanelManageSales.Visible = false;
        }
        private void showsubpanels(Panel subpanel)
        {
            //show the subpanel when a of the category that the user clicked
            if (subpanel.Visible == false)
            {
                hidesubpanels();
                subpanel.Visible = true;
            }
            else
                subpanel.Visible = false;

        }
        private void AdminPosStartUp_Load(object sender, EventArgs e)
        {
            //Admin form
            
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            showsubpanels(SubpanelEmployee);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            openMiniForm(new AddEmployeeForm());

            // magdagdag ng alipin
            hidesubpanels();
        }
        private void btnRmvEmp_Click(object sender, EventArgs e)
        {
            openMiniForm(new RemoveEmployeeForm());
            
            //patalsikin ang alipin
            hidesubpanels();
        }

        private void btnTimeInOut_Click(object sender, EventArgs e)
        {
            openMiniForm(new CheckTimeInOutForm());

            //code here
            hidesubpanels();
        }
        private void btnEditEmpInfo_Click(object sender, EventArgs e)
        {
            openMiniForm(new EditEmployeeForm());

            //magedit ng alipin
            hidesubpanels();
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            openMiniForm(new Salary_form());

            //code nyaaannn neko nyaan
            hidesubpanels();
        }
        private void btnManga_Click(object sender, EventArgs e)
        {
            //wala to
            showsubpanels(SubPanelManga);
        }

        private void btnAddManga_Click(object sender, EventArgs e)
        {
            openMiniForm(new AddMangaForm());

            //code na magdadagdag mangga
            hidesubpanels();
        }

        private void btnRmvManga_Click(object sender, EventArgs e)
        {
            openMiniForm(new RemoveMangaForm());

            //code na tatanggalin ang mangga
            hidesubpanels();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            showsubpanels(SubPanelManageSales);
        }

        private void btnSellManga_Click(object sender, EventArgs e)
        {
            openMiniForm(new SellMangaForm());

            //code na magbebenta ng mangga
            hidesubpanels();
        }

        private void btnReciepts_Click(object sender, EventArgs e)
        {
            openMiniForm(new RecieptsForm());

            //==
            //mga resibo
            hidesubpanels();
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            openMiniForm(new GenerateReportForm());

            //Monthly report of sales
            hidesubpanels();
        }

        private Form openform = null;
        private void openMiniForm(Form Miniform)
        {
            //def for buttons opening the miniforms
            if (openform != null)
                openform.Close();
            openform = Miniform;
            Miniform.TopLevel = false;
            Miniform.FormBorderStyle = FormBorderStyle.None;
            Miniform.Dock = DockStyle.Fill;
            AdminScreenPanel.Controls.Add(Miniform);
            AdminScreenPanel.Tag = Miniform;
            Miniform.BringToFront();
            Miniform.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout ?", "MangaFlixie POS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Thread.Sleep(2500);
                Form1 n = new Form1();
                n.Show();
            }
        }

        private void AdminScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
