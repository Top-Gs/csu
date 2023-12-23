using CSU.Domain.News;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSU.Infrastructure.News.Persistence
{
    public class ImageConnfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ImageData)
                .IsRequired();

            builder
                .HasOne(i => i.News)
                .WithMany(i => i.Images)
                .HasForeignKey(i => i.NewsId)
                .IsRequired();
        }
    }
}
