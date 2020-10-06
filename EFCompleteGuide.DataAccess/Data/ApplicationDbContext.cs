using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCompleteGuide.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}