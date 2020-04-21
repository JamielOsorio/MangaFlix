using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MangaFlix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            MongoCRUD db = new MongoCRUD("Employees");
            //db.InsertRecord("Employee/s", new Employee { Username =, Password =}); //insert the username and password to the database
            //var recs = db.LoadRecords<Employee>("Employee/s");

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{ rec.Id }: { rec.Username} {rec.Password}");
            //}
            //db.LoadRecordById<Employee>("Employee/s", new Guid());
        }
    }

    public class Employee
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        //MongoCRUD db = new MongoCRUD("MangaFlixie");
        //db.InsertRecord("Employees", new Employee { Username =, Password =});
    }




    public class Manga
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string MangaTitle { get; set; }
        public string MangaAuthor { get; set; }
        public string MangaGenre { get; set; }
        public double MangaPrice { get; set; }
        public int MangaStock { get; set; }
        //MongoCRUD db = new MongoCRUD("MangaFlixie");
        //db.InsertRecord("Manga/s", new Manga { MangaTitle =, MangaAuthor =, MangaAuthor=});
    }

    public class EmployeeInfo
    {
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        //public string  { get; set; }
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
            
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

    }
}
