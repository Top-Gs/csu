using CSU.Domain.Members;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSU.Infrastructure.Members.Persistence
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Type)
                .HasConversion(
                    mtype => mtype.Value,
                    value => MemberType.FromValue(value))
                .IsRequired();

            builder.Property(m => m.Position)
                .HasConversion(
                    position => position.Value,
                    value => Position.FromValue(value))
                .IsRequired();

            builder.Property(m => m.FirstName)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(m => m.LastName)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(m => m.Nationality)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(m => m.BirthDate)
                .IsRequired();

            builder.Property(m => m.Height)
                .IsRequired();

            builder
                .Property(m => m.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(m => m.ModifiedAt)
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasOne(m => m.User)
                .WithMany(m => m.Members)
                .HasForeignKey(m => m.UserId)
                .IsRequired();

            builder
                .HasMany(a => a.Awards)
                .WithMany(m => m.Members)
                .UsingEntity(
                    "MembersAwards",
                    l => l.HasOne(typeof(Award)).WithMany().HasForeignKey("AwardId").HasPrincipalKey(nameof(Award.Id)),
                    r => r.HasOne(typeof(Member)).WithMany().HasForeignKey("MemberId").HasPrincipalKey(nameof(Member.Id)),
                    j => j.HasKey("MemberId", "AwardId"));

            builder.HasMany(r => r.Roles)
                .WithMany(m => m.Members)
                .UsingEntity<MemberRole>(j => j.Property(e => e.CreatedAt).HasDefaultValueSql("getutcdate()"));

            builder
                .HasMany(c => c.Championships)
                .WithMany(m => m.Members)
                .UsingEntity(
                    "MembersChampionships",
                    l => l.HasOne(typeof(Championship)).WithMany().HasForeignKey("ChampionshipId").HasPrincipalKey(nameof(Championship.Id)),
                    r => r.HasOne(typeof(Member)).WithMany().HasForeignKey("MemberId").HasPrincipalKey(nameof(Member.Id)),
                    j => j.HasKey("MemberId", "ChampionshipId"));
        }
    }
}
