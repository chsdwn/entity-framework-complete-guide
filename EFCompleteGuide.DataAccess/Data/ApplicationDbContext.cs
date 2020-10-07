using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCompleteGuide.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlite("Data Source=CleanCode.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<BookAuthor>()
                .HasKey(bookAuthor => new { bookAuthor.Author_Id, bookAuthor.Book_Id });

            /* --- FluentBookDetails --- */
            // Key
            modelBuilder.Entity<FluentBookDetail>().HasKey(b => b.BookDetail_Id);
            // Required
            modelBuilder.Entity<FluentBookDetail>().Property(b => b.NumberOfChapters).IsRequired();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<FluentBookDetail> FluentBookDetails { get; set; }
    }
}