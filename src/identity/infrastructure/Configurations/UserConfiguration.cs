using FamilyBudget.Identity.Domain.Users;

namespace FamilyBudget.Identity.Infrastructure.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder.Property(user => user.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(user => user.Email).IsRequired().HasMaxLength(256);
        builder.HasIndex(user => user.Email).IsUnique();
        builder.Property(user => user.EmailConfirmed).IsRequired();

        builder.Property(user => user.PasswordHash).IsRequired().HasMaxLength(1512);

        builder.ComplexProperty(user => user.Name, nameBuilder =>
        {
            nameBuilder.Property(vo => vo.First).IsRequired().HasMaxLength(100);
            nameBuilder.Property(vo => vo.Last).IsRequired().HasMaxLength(200);
        });
    }
}