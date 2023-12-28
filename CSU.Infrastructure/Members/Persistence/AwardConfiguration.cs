using CSU.Domain.Members;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSU.Infrastructure.Members.Persistence
{
    public class AwardConfiguration : IEntityTypeConfiguration<Award>
    {
        public void Configure(EntityTypeBuilder<Award> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(a => a.Place)
                .IsRequired();

            builder.Property(a => a.Championship)
                .HasMaxLength(250);

            builder.Property(a => a.Date)
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasOne(a => a.Member)
                .WithMany(a => a.Awards)
                .HasForeignKey(a => a.MemberId)
                .IsRequired();
        }
    }
}
