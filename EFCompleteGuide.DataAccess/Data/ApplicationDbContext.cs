using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCompleteGuide.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlite("Data Source=CleanCode.db");

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}