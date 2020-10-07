using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCompleteGuide.DataAccess.FluentConfig
{
    public class FluentBookConfig : IEntityTypeConfiguration<FluentBook>
    {
        public void Configure(EntityTypeBuilder<FluentBook> builder)
        {
            builder.HasKey(b => b.Book_Id);
            builder.Property(b => b.ISBN).IsRequired().HasMaxLength(15);
            builder.Property(b => b.Title).IsRequired();
            builder.Property(b => b.Price).IsRequired();
            builder
                .HasOne(b => b.FluentBookDetail)
                .WithOne(bd => bd.FluentBook)
                .HasForeignKey<FluentBook>($"{nameof(FluentBookDetail)}_Id");
            builder
                .HasOne(b => b.FluentPublisher)
                .WithMany(bp => bp.FluentBooks)
                .HasForeignKey(b => b.FluentPublisher_Id);
        }
    }
}