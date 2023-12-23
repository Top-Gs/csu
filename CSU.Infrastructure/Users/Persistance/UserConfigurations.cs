using CSU.Domain.Users;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSU.Infrastructure.Users.Persistance
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(n => n.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(n => n.Email)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(n => n.Password)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(n => n.Role)
                .HasConversion(
                    state => state.Value,
                    value => UserRole.FromValue(value))
                .IsRequired();

            builder
                .HasMany(e => e.News)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
