using KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<BookGenre> GenreBooks { get; set; }

        public DbSet<BookAuthor> AuthorBooks { get; set; }

        public BooksDbContext()
        {
            
        }
    }
}
