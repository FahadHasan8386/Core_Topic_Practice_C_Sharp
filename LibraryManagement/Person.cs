using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
    public abstract class Person
    {
        public string Name { get; set; }

        public abstract void DisplayInfo();
    }
}
