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
                .HasMaxLength(250);

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
                .HasMany(e => e.Awards)
                .WithOne(e => e.Member)
                .HasForeignKey(e => e.MemberId)
                .IsRequired();

            builder
                .HasMany(e => e.Roles)
                .WithOne(e => e.Member)
                .HasForeignKey(e => e.MemberId)
                .IsRequired();
        }
    }
}
