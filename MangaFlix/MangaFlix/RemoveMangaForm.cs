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
    public partial class RemoveMangaForm : Form
    {
        public RemoveMangaForm()
        {
            InitializeComponent();
        }

        private void btnCloseRemoveManga_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
