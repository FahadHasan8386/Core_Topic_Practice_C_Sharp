using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Interface
{
    public interface IBorrowable
    {
        void Borrow();
        void Return();
    }
}
