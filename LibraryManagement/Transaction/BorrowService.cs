using LibraryManagement.Books;
using LibraryManagement.Interface;
using LibraryManagement.Members;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Transaction
{
    public class BorrowService : IBorrowable
    {
        public void Borrow()
        {
            Console.WriteLine("Borrow a book.");
        }

        public void Return()
        {
            Console.WriteLine("Return a book");
        }

        public void BorrowBook(Book book , Member member)
        {
            Console.WriteLine($"{member.Name} borrowed {book.Title}");
        }
        public void ReturnBook(Book book, Member member)
        {
            Console.WriteLine($"{member.Name} returned {book.Title}");
        }

    }
}
