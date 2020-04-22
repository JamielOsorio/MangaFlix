using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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
    public partial class RemoveEmployeeForm : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("MangaFlixie");
        static IMongoCollection<EmployeeName> collection = db.GetCollection<EmployeeName>("Employees");

        public void ReadAllDocuments()
        {
            List<EmployeeName> list = collection.AsQueryable().ToList();
            dataGridRemoveEmployee.DataSource = list;

            try
            {
                textBox1.Text = dataGridRemoveEmployee.Rows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridRemoveEmployee.Rows[0].Cells[1].Value.ToString();
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        public RemoveEmployeeForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void btnCloseRemoveEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridRemoveEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridRemoveEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridRemoveEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
                MessageBox.Show("The I.D. field is empty.","MangaFlixie POS");
            }
        }
    }
}
