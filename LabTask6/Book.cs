using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask6
{
    class Book
    {
        string name;
        string author;
        string bookId;
        string bookType;
        int bookCopy;

        Book()
        {
            Console.WriteLine("Default Book Constructor");
        }

        Book(string name, string author, string bookId, string bookType, int bookCopy)
        {
            this.name = name;
            this.author = author;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void showInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Book Type: " + bookType);
            Console.WriteLine("Book Copies: " + bookCopy);
        }

        public void AddBookCopy(int x)
        {

        }
    }
}
