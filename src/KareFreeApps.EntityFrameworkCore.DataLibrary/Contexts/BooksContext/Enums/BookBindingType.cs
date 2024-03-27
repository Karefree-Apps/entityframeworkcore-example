using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Enums
{
    public enum BookBindingType
    {
        Unknown = 0,
        Paperback = 1,
        Hardcover = 2,
        Leatherbound = 3,
        Spiralbound = 4,
        Boardbook = 5,
        eBook = 6,
        Other = 99
    }
}
