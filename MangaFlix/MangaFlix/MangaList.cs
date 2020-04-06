using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaFlix
{
    class MangaList
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("MangaTitle")]
        public string MangaTitle { get; set; }
        [BsonElement("MangaAuthor")]
        public string MangaAuthor { get; set; }
        [BsonElement("MangaGenre")]
        public string MangaGenre { get; set; }
        [BsonElement("MangaPrice")]
        public double MangaPrice { get; set; }
        [BsonElement("MangaStock")]
        public int MangaStock { get; set; }

        public MangaList(string mangaTitle, string mangaAuthor, string mangaGenre, double mangaPrice, int mangaStock)
        {
            MangaTitle = mangaTitle;
            MangaAuthor = mangaAuthor;
            MangaGenre = mangaGenre;
            MangaPrice = mangaPrice;
            MangaStock = mangaStock;
        }
    }
}
