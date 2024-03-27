namespace KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Entities
{
    public class BookAuthor
    {
        public int BookAuthorId { get; set; }

        public Guid BookId { get; set; }

        public int AuthorId { get; set; }

        public DateTimeOffset AuthoredOnUtc { get; set; }

    }
}
