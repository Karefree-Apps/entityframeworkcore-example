using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Entities
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int PageCount { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; } = [];

        public virtual ICollection<BookGenre> BookGenres { get; set; } = [];

        public virtual ICollection<BookPublisher> BookPublishers { get; set; } = [];
    }
}
