using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_1_.Classses
{
    public class Book
    {
        public readonly string name;
        public readonly string author;
        public readonly string publisher;

        public Book(string name, string author, string publisher)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            BookShelf.AddBook(this);
        }

        public override string ToString()
        {
            return $"{name} - {author} - {publisher}";
        }
    }
}
