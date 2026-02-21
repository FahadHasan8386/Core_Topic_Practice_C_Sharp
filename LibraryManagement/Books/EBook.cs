using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Books
{
    public class EBook : Book
    {
        public override void ShowInfo()
        {
            Console.WriteLine($"SpecialBook Info: {Title} by {Author}");
        }
    }
}
