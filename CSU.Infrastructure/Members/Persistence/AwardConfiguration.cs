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

            builder.Property(a => a.TeamAward)
                .IsRequired();

            builder
                .HasOne(a => a.Championship)
                .WithMany(a => a.Awards)
                .HasForeignKey(a => a.ChampionshipId)
                .IsRequired();
        }
    }
}
