using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    // Класс "Книга"
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string title, string author, int pageCount)
        {
            Title = title throw new ArgumentNullExseption(nameof(Title));
            Author = author throw new ArgumentNullExseption(nameof(Author));
            PageCount = pageCount;
        }

        public override string ToString()
        {
            return $"{Author}: {Title}";
        }
    }

    // Класс "Библиотека" - наследник списка книг
    public class Library : List<Book>
    {
        public void SortByPageCount()
        {
            this.Sort((book1, book2) => book1.PageCount.CompareTo(book2.PageCount));
        }

        public void PrintBooks()
        {
            foreach (var book in this)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }

    // Методы расширения
    public static class LibraryExtensions
    {
        public static void AddBooks(Library library, params Book[] books)
      
            foreach (var book in books)
            {
                library.Add(book);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание библиотеки и добавление книг
            Library library = new Library();
            library.AddBooks(
                new Book("1984", "George Orwell", 328),
                new Book("To Kill a Mockingbird", "Harper Lee", 281),
                new Book("The Great Gatsby", "F. Scott Fitzgerald", 180),
                new Book("One Hundred Years of Solitude", "Gabriel Garcia Marquez", 417),
                new Book("Moby Dick", "Herman Melville", 635)
            );

            // Вывод списка книг до сортировки
            Console.WriteLine("Books before sorting:");
            library.PrintBooks();

            // Сортировка книг по количеству страниц
            library.SortByPageCount();

            // Вывод списка книг после сортировки
            Console.WriteLine("\nBooks after sorting by page count:");
            library.PrintBooks();
        }
    }
}