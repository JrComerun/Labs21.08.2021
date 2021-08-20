using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Library library = new Library("Kitabxana");

            Book book = new Book("Gecenin Qaranligi","JrC","Russian");
            Book book2 = new Book("Gecenin Qaranligi2","JrC","Russian");
            Book book3 = new Book("Gecenin Qaranligi3","JrC","Russian");

            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);
            
            library.FindBookForId(3);
            library.ShowBooks();
            //Console.WriteLine(library.Id);
            //Console.WriteLine(library2.Id);
        }
    }
}
