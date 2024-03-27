namespace KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Entities
{
    public class BookGenre
    {
        public int BookGenreId { get; set; }

        public Guid BookId { get; set; }

        public int GenreId { get; set; }

    }
}
