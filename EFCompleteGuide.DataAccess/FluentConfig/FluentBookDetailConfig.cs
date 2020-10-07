using EFCompleteGuide.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCompleteGuide.DataAccess.FluentConfig
{
    public class FluentBookDetailConfig : IEntityTypeConfiguration<FluentBookDetail>
    {
        public void Configure(EntityTypeBuilder<FluentBookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetail_Id);
            builder.Property(bd => bd.NumberOfChapters).IsRequired();
        }
    }
}