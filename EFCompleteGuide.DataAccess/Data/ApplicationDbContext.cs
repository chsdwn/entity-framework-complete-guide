using System;
using System.IO;
using EFCompleteGuide.DataAccess.FluentConfig;
using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCompleteGuide.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlite($"Data Source={Path.Combine(Directory.GetCurrentDirectory(), "CleanCode.db")}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<BookAuthor>()
                .HasKey(bookAuthor => new { bookAuthor.Author_Id, bookAuthor.Book_Id });

            modelBuilder.Entity<Category>().ToTable("tbl_Categories");
            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("CategoryName");

            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
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