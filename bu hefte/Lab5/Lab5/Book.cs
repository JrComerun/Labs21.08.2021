using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Book
    {
        public int Id { get; set; }
        private static int _id = 0;

        public string Name { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int? Price { get; set; }
        public bool IsOld { get; set; }
        public DateTime CreateTime { get; set; }
        public Book(string name,string author,string language)
        {
            Name = name;
            Author = author;
            Language = language;
            _id++;
            Id = _id;
            CreateTime = DateTime.UtcNow.AddHours(4);
        }
        public Book()
        {
                
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
