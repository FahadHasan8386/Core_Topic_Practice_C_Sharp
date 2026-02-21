using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LibraryManagement.Books
{
    public partial class Book
    {
        public String Author { get; set; }
        public void PrintDetails()
        {
            Console.WriteLine($"Book : {Title}");
        }

        public void PrintDetails(bool showAuthor) => Console.WriteLine($"Book: {Title}, Author: {Author}");

        public virtual void ShowInfo() => Console.WriteLine($"Book Info: {Title} by {Author}");
    }
}
