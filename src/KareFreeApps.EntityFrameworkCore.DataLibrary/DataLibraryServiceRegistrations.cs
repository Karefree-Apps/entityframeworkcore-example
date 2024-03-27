using KareFreeApps.EntityFrameworkCore.DataLibrary.Contexts.BooksContext;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KareFreeApps.EntityFrameworkCore.DataLibrary
{
    public static class DataLibraryServiceRegistrations
    {
        public static IServiceCollection RegisterDataLibraryServices(this IServiceCollection services, Action<DbContextOptionsBuilder> booksDbContextBuilder)
        {
            services.AddDbContextPool<BooksDbContext>(booksDbContextBuilder);            
            return services;
        }

    }
}
