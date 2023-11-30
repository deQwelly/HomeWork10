using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_1_.Classses
{
    public static class BookShelf
    {
        private static List<Book> books = new List<Book>();

        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        public static void SortByName()
        {
            SortedDictionary<string, Book> booksDict = new SortedDictionary<string, Book>();
            foreach (Book book in books)
            {
                booksDict.Add(book.name, book);
            }
            books = booksDict.Values.ToList();
        }

        public static void SortByAuthor()
        {
            SortedDictionary<string, Book> booksDict = new SortedDictionary<string, Book>();
            foreach (Book book in books)
            {
                booksDict.Add(book.author, book);
            }
            books = booksDict.Values.ToList();
        }

        public static void SortByPublisher()
        {
            SortedDictionary<string, Book> booksDict = new SortedDictionary<string, Book>();
            foreach (Book book in books)
            {
                booksDict.Add(book.publisher, book);
            }
            books = booksDict.Values.ToList();
        }

        public static void ShowShelf()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}