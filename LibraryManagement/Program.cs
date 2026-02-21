using LibraryManagement.Books;
using LibraryManagement.Members;
using LibraryManagement.Transaction;
using LibraryManagement.Utilities;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("Library Management Started");

            // Library
            Library lib = new Library();
            Console.WriteLine($"Welcome to {Library.LibraryName}, created at {lib.CreatedDate}");

            //// Member
            //Member m1 = new Member(1, "Fahad", 20);
            //m1.DisplayInfo();

            // Books
            Book b1 = new Book { Title = "C# Basics", Author = "John Doe" };
            b1.PrintDetails();
            b1.PrintDetails(true);

            EBook eb = new EBook { Title = "Advanced C#", Author = "Jane Doe" };
            eb.ShowInfo();

            SpecialBook sb = new SpecialBook { Title = "Secrets of C#", Author = "Mark Twain" };
            sb.ShowInfo();

            // Lambda example
            var books = new List<Book> { b1, eb, sb };
            var titles = books.Select(book => book.Title).ToList();
            Console.WriteLine("Book Titles: " + string.Join(", ", titles));

            // Borrow Service
            BorrowService borrowService = new BorrowService();
            //borrowService.BorrowBook(b1, m1);
            //borrowService.ReturnBook(b1, m1);

            Logger.Log("Library Management Finished");
        }
    }
}