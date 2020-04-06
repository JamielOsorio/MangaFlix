using MongoDB.Bson;
using MongoDB.Driver;
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
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("MangaFlixie");
        static IMongoCollection<MangaList> collection = db.GetCollection<MangaList>("Mangas");

        public void ReadAllDocuments()
        {
            List<MangaList> list = collection.AsQueryable().ToList();
            dataGridRemoveEmployee.DataSource = list;

            try
            {
                textBox1.Text = dataGridRemoveEmployee.Rows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridRemoveEmployee.Rows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridRemoveEmployee.Rows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridRemoveEmployee.Rows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridRemoveEmployee.Rows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridRemoveEmployee.Rows[0].Cells[4].Value.ToString();
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }

        }
        public RemoveMangaForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void btnCloseRemoveManga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridRemoveEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                return;
            }

        }

        private void btnRmvEmployeeRemove_Click(object sender, EventArgs e)
        {
            try
            {
                collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("There is nothing to delete.", "MangaFlixie POS");
            }
            ReadAllDocuments();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
            }
        }

        private void dataGridRemoveEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("The I.D. field is empty.", "MangaFlixie POS");
            }
        }
    }
}
