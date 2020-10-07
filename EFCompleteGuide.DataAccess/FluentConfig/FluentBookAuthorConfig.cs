using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCompleteGuide.DataAccess.FluentConfig
{
    public class FluentBookAuthorConfig : IEntityTypeConfiguration<FluentBookAuthor>
    {
        public void Configure(EntityTypeBuilder<FluentBookAuthor> builder)
        {
            builder.HasKey(ba => new { ba.FluentAuthor_Id, ba.FluentBook_Id });
            builder
                .HasOne(ba => ba.FluentAuthor)
                .WithMany(a => a.FluentBookAuthors)
                .HasForeignKey(ba => ba.FluentAuthor_Id);
            builder
                .HasOne(ba => ba.FluentBook)
                .WithMany(b => b.FluentBookAuthors)
                .HasForeignKey(ba => ba.FluentBook_Id);
        }
    }
}