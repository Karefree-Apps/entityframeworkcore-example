using KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Enums;

namespace KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }        

        public BookGenreType GenreType { get; set; } = BookGenreType.Unknown;
    }
}
