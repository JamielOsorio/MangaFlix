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
    public partial class CheckTimeInOutForm : Form
    {
        public CheckTimeInOutForm()
        {
            InitializeComponent();
        }

        private void btnCloseCheckInOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
