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
    public partial class CheckTimeInOutForm : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("MangaFlixie");
        static IMongoCollection<CheckTimeInOut> collection = db.GetCollection<CheckTimeInOut>("Employees");

        //public void ReadAllDocuments()
        //{
        //    List<CheckTimeInOut> list = collection.AsQueryable().ToList();
        //    dataGridCheckInOut.DataSource = list;
        //}
        public CheckTimeInOutForm()
        {
            InitializeComponent();
            //ReadAllDocuments();
        }

        private void btnCloseCheckInOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
