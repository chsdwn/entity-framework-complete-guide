using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCompleteGuide.DataAccess.FluentConfig
{
    public class FluentAuthorConfig : IEntityTypeConfiguration<FluentAuthor>
    {
        public void Configure(EntityTypeBuilder<FluentAuthor> builder)
        {
            builder.HasKey(a => a.Author_Id);
            builder.Property(a => a.FirstName).IsRequired();
            builder.Property(a => a.LastName).IsRequired();
            builder.Ignore(a => a.FullName);
        }
    }
}