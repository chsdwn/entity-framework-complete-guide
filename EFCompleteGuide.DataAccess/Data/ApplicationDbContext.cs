using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCompleteGuide.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlite("Data Source=CleanCode.db");

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}