using CSU.Domain.Members;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSU.Infrastructure.Members.Persistence
{
    public class ChampionshipConfiguration : IEntityTypeConfiguration<Championship>
    {
        public void Configure(EntityTypeBuilder<Championship> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder
                .HasMany(c => c.Awards)
                .WithOne(c => c.Championship)
                .HasForeignKey(c => c.ChampionshipId)
                .IsRequired();
        }
    }
}
