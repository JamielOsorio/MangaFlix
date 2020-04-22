using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MangaFlix
{
    public partial class PosStartUp : Form
    {
        public PosStartUp()
        {
            InitializeComponent();
            subpanelspopup();
        }

        private void hidesubpanels()
        {
            if (subpanel_MngSales.Visible == true)
                subpanel_MngSales.Visible = false;
            if (subpanel_MngInv.Visible == true)
                subpanel_MngInv.Visible = false;
        
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

        private void subpanelspopup()
        {
            //hide all subpanels
            subpanel_MngSales.Visible = false;
            subpanel_MngInv.Visible = false;

        }

        private void PosStartUp_Load(object sender, EventArgs e)
        {
            
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ChildFormContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form openform = null;
        private void openatMainForm(Form Miniform)
        {
            //def for buttons opening the childforms at childform container
            if (openform != null)
                openform.Close();
            openform = Miniform;
            Miniform.TopLevel = false;
            Miniform.FormBorderStyle = FormBorderStyle.None;
            Miniform.Dock = DockStyle.Fill;
            ChildFormContainer.Controls.Add(Miniform);
            ChildFormContainer.Tag = Miniform;
            Miniform.BringToFront();
            Miniform.Show();
        }
        
        private void btnMng_Manga_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMng_Sales_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout ?", "MangaFlixie POS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Thread.Sleep(2500);
                Form1 n = new Form1();
                n.Show();
            }
        }

        private void btnMng_Sales_Click_1(object sender, EventArgs e)
        {
            showsubpanels(subpanel_MngSales);
        }

        private void btnMng_Manga_Click_1(object sender, EventArgs e)
        {
            showsubpanels(subpanel_MngInv);
        }

        private void btn_SellManga_Click(object sender, EventArgs e)
        {
            openatMainForm(new SellMangaForm());
        }

        private void btn_Receipts_Click(object sender, EventArgs e)
        {
            openatMainForm(new RecieptsForm());
        }


        private void btnGenReport_Click(object sender, EventArgs e)
        {
            openatMainForm(new GenerateReportForm());
        }

        private void btn_AddManga_Click(object sender, EventArgs e)
        {
            openatMainForm(new AddMangaForm());
        }

        private void btn_RmvManga_Click(object sender, EventArgs e)
        {
            openatMainForm(new RemoveMangaForm());
        }
    }
}
