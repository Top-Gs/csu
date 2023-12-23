using CSU.Domain.News;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSU.Infrastructure.News.Persistence
{
    public class HashtagConfiguration : IEntityTypeConfiguration<Hashtag>
    {
        public void Configure(EntityTypeBuilder<Hashtag> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
