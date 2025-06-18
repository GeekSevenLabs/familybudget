using FamilyBudget.Identity.Domain;
using FamilyBudget.Identity.Domain.Users;
using FamilyBudget.Identity.Infrastructure.Configurations;

namespace FamilyBudget.Identity.Infrastructure.Contexts;

public class IdentityDbContext(DbContextOptions<IdentityDbContext> options) : DbContext(options), IIdentityUnitOfWork
{
    public required DbSet<User> Users { get; init; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
    
    public new async Task SaveChangesAsync(CancellationToken cancellationToken = default) => await base.SaveChangesAsync(cancellationToken);
}