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
    public partial class AddMangaForm : Form
    {
        public AddMangaForm()
        {
            InitializeComponent();
        }

        private void btnCloseAddMangaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MongoCRUD db = new MongoCRUD("MangaFlixie");
           
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox3.Text != ""))
            {
                db.InsertRecord("Mangas", new Manga { MangaTitle = textBox1.Text, MangaAuthor = textBox4.Text, MangaGenre = textBox2.Text, MangaPrice = double.Parse(textBox5.Text), MangaStock = int.Parse(textBox3.Text) });
                MessageBox.Show("A new manga has been added!", "MangaFlixie POS", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Please input a valid character/integer or fill out the missing informations.", "MangaFlixie POS");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only numbers
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
