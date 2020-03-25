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
            //code here, magdagdag ng alipin
            hidesubpanels();
        }
        private void btnRmvEmp_Click(object sender, EventArgs e)
        {
            //code here, patalsikin ang alipin
            hidesubpanels();
        }

        private void btnTimeInOut_Click(object sender, EventArgs e)
        {
            //code here
            hidesubpanels();
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            //code nyaaannn neko nyaan
            hidesubpanels();
        }
        private void btnManga_Click(object sender, EventArgs e)
        {
            //kapag naclick to automatic na maviewview yung mga manga instore
            showsubpanels(SubPanelManga);
        }

        private void btnAddManga_Click(object sender, EventArgs e)
        {
            //code na magdadagdag mangga
            hidesubpanels();
        }

        private void btnRmvManga_Click(object sender, EventArgs e)
        {
            //code na tatanggalin ang mangga
            hidesubpanels();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            showsubpanels(SubPanelManageSales);
        }

        private void btnSellManga_Click(object sender, EventArgs e)
        {
            
            //code na magbebenta ng mangga
            hidesubpanels();
        }

        private void btnReciepts_Click(object sender, EventArgs e)
        {
            //==
            //mga resibo
            hidesubpanels();
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            //Monthly report of sales
            hidesubpanels();
        }
    }
}
