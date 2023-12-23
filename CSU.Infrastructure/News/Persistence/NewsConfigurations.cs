using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NewsDomain = CSU.Domain.News;

namespace CSU.Infrastructure.News.Persistence
{
    public class NewsConnfiguration : IEntityTypeConfiguration<NewsDomain.News>
    {
        public void Configure(EntityTypeBuilder<NewsDomain.News> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.Title)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(n => n.Description)
                .IsRequired();

            builder.Property(n => n.State)
                .HasConversion(
                    state => state.Value,
                    value => NewsDomain.NewsState.FromValue(value))
                .IsRequired();

            builder
                .Property(n => n.ScheduledDate)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(n => n.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(n => n.ModifiedAt)
                .HasDefaultValueSql("GETDATE()");

            builder
                 .HasMany(e => e.Images)
                 .WithOne(e => e.News)
                 .HasForeignKey(e => e.NewsId)
                 .IsRequired();

            builder
                .HasMany(e => e.Hashtags)
                .WithMany(e => e.News)
                .UsingEntity(
                    "NewsHashtag",
                    l => l.HasOne(typeof(NewsDomain.Hashtag)).WithMany().HasForeignKey("HashtagId").HasPrincipalKey(nameof(NewsDomain.Hashtag.Id)),
                    r => r.HasOne(typeof(NewsDomain.News)).WithMany().HasForeignKey("NewsId").HasPrincipalKey(nameof(NewsDomain.News.Id)),
                    j => j.HasKey("NewsId", "HashtagId"));

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.News)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
