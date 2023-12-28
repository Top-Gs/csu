using CSU.Domain.Members;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSU.Infrastructure.Members.Persistence
{
    public class RoleConfiguration : IEntityTypeConfiguration<MemberRole>
    {
        public void Configure(EntityTypeBuilder<MemberRole> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(m => m.Date)
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasOne(r => r.Member)
                .WithMany(r => r.Roles)
                .HasForeignKey(r => r.MemberId)
                .IsRequired();
        }
    }
}
