using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Book
    {
        private string author = "unknown";
        private string title = "unknown";
        private string pages = "unknown";
        private bool collectorsEdition = false;



        public Book(string author, string title, string pages, bool collectorsEdition)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.collectorsEdition = collectorsEdition;
        }
        public Book()
        {
            author = "unknown";
            title = "unknown";
            pages = "unknown";
            collectorsEdition = false;
        }

        public Book(string author, string title, bool collectorsEdition)
        {
            this.author = author;
            this.title = title;
            this.collectorsEdition = collectorsEdition;
        }

        public Book(string title, bool collectorsEdition)
        {
            this.title = title;
            this.collectorsEdition = collectorsEdition;
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Страниц: " + pages);
            Console.WriteLine("Коллекционное издание: " + collectorsEdition);
            Console.WriteLine();
            Console.WriteLine("");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Гомер", "Одиссея", "450", false);
            Book book2 = new Book("Ken Kesey", "One Flew Over the Cuckoo`s Nest", "390", false);
            Book book3 = new Book("George R. R. Martin", "A Knight of the Seven Kingdoms", "256", false);
            Book book4 = new Book("Джордж Оруэлл", "1984","287", true);
            book1.Output();
            book2.Output();
            book3.Output();
            book4.Output();
            Console.ReadKey();
        }
    }
}
