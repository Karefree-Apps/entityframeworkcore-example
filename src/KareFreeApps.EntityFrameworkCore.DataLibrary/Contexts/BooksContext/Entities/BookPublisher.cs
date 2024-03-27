using KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Enums;

namespace KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Entities
{
    public class BookPublisher
    {
        public int BookPublisherId { get; set; }

        public Guid BookId { get; set; }

        public int PublisherId { get; set; }

        public DateTimeOffset PublishedOnUtc { get; set; }

        public BookBindingType BookBindingType { get; set; } = BookBindingType.Unknown;

    }
}
