using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Members
{
    public class Member : Person
    {
        private int _memberId;
        public int MemberId { get; set; }
        public int Age { get; private set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {MemberId}, Name: {Name}, Age: {Age}");
        }
    }
}
