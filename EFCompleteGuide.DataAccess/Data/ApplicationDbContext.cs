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

            modelBuilder.Entity<Category>().ToTable("tbl_Categories");
            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("CategoryName");

            #region FLUENT_MODELS
            modelBuilder.Entity<FluentAuthor>().HasKey(a => a.Author_Id);
            modelBuilder.Entity<FluentAuthor>().Property(a => a.FirstName).IsRequired();
            modelBuilder.Entity<FluentAuthor>().Property(a => a.LastName).IsRequired();
            modelBuilder.Entity<FluentAuthor>().Ignore(a => a.FullName);

            modelBuilder.Entity<FluentBook>().HasKey(b => b.Book_Id);
            modelBuilder.Entity<FluentBook>().Property(b => b.ISBN).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<FluentBook>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<FluentBook>().Property(b => b.Price).IsRequired();
            modelBuilder.Entity<FluentBook>()
                        .HasOne(b => b.FluentBookDetail)
                        .WithOne(bd => bd.FluentBook)
                        .HasForeignKey<FluentBook>($"{nameof(FluentBookDetail)}_Id");
            modelBuilder.Entity<FluentBook>()
                        .HasOne(b => b.FluentPublisher)
                        .WithMany(bp => bp.FluentBooks)
                        .HasForeignKey(b => b.FluentPublisher_Id);

            modelBuilder.Entity<FluentBookAuthor>().HasKey(ba => new { ba.FluentAuthor_Id, ba.FluentBook_Id });
            modelBuilder.Entity<FluentBookAuthor>()
                        .HasOne(ba => ba.FluentAuthor)
                        .WithMany(a => a.FluentBookAuthors)
                        .HasForeignKey(ba => ba.FluentAuthor_Id);
            modelBuilder.Entity<FluentBookAuthor>()
                        .HasOne(ba => ba.FluentBook)
                        .WithMany(b => b.FluentBookAuthors)
                        .HasForeignKey(ba => ba.FluentBook_Id);

            modelBuilder.Entity<FluentBookDetail>().HasKey(bd => bd.BookDetail_Id);
            modelBuilder.Entity<FluentBookDetail>().Property(bd => bd.NumberOfChapters).IsRequired();

            modelBuilder.Entity<FluentPublisher>().HasKey(p => p.Publisher_Id);
            modelBuilder.Entity<FluentPublisher>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<FluentPublisher>().Property(p => p.Location).IsRequired();
            #endregion
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<FluentAuthor> FluentAuthors { get; set; }
        public DbSet<FluentBook> FluentBooks { get; set; }
        public DbSet<FluentBookDetail> FluentBookDetails { get; set; }
        public DbSet<FluentPublisher> FluentPublishers { get; set; }
    }
}