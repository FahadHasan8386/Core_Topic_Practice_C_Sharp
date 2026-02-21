using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Books
{
    public sealed class SpecialBook : Book
    {
        public new void ShowInfo()
        {
            Console.WriteLine($"SpecialBook Info: {Title} by {Author}");
        }
    }
}
