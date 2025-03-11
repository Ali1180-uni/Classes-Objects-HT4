using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects_HT3
{
  internal class library
    {
        private book[] book1;
        private int bookCount;

        public library()
        {
            book1 = new book[100];
            bookCount = 0;
        }

        public void Add(book newBook)
        {
            if (bookCount < book1.Length)
            {
                book1[bookCount] = newBook;
                bookCount++;
                Console.WriteLine("Book Added Successfully!");
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }
        }

        public void list()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }

            Console.WriteLine("\nAll The Books Are: ");
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"<----------------|Book {i + 1}|---------------->");
                Console.WriteLine($"Title: {book1[i].Title}");
                Console.WriteLine($"Author: {book1[i].Auther}");
                Console.WriteLine($"Genre: {book1[i].Genre}");
                Console.WriteLine($"Publication Year: {book1[i].PubYear}");
            }
        }

        public void Search(string name)
        {
            bool found = false;
            for (int i = 0; i < bookCount; i++)
            {
                if (book1[i].Title == name || book1[i].Auther == name || book1[i].Genre == name)
                {
                    Console.WriteLine("\nBook Found!");
                    Console.WriteLine($"Title: {book1[i].Title}");
                    Console.WriteLine($"Author: {book1[i].Auther}");
                    Console.WriteLine($"Genre: {book1[i].Genre}");
                    Console.WriteLine($"Publication Year: {book1[i].PubYear}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("\nNo matching book found.");
            }
        }
    }
}

