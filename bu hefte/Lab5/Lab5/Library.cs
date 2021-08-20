using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Library
    {
        public int Id { get; set; }
        private static int _id = 0;
        
        public string Name { get; set; }
        public DateTime CreateTime { get; }
        private List<Book> Books;
        public Library(string name)
        {
            Name = name;
            _id++;
            Id = _id;
            CreateTime = DateTime.UtcNow.AddHours(4);
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void ShowBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book);
            }
        }
        public Book FindBookForId(int id)
        {
            
            Book result = new Book();
            foreach (Book book in Books)
            {
                if (id == book.Id)
                {
                    result = book;
                }
            }
            return result;

        }
        public void RemoveBook(int id)
        {
            foreach (Book book in Books)
            {
                if (id == book.Id)
                {
                    Books.Remove(book);
                }
            }
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
