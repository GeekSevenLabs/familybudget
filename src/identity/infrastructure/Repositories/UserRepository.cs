using FamilyBudget.Identity.Domain.Users;
using FamilyBudget.Identity.Infrastructure.Contexts;

namespace FamilyBudget.Identity.Infrastructure.Repositories;

internal class UserRepository(IdentityDbContext db) : IUserRepository
{
    public void Add(User user) => db.Users.Add(user);
    public async Task<User?> GetByEmailAsync(string email) => await db.Users.FindAsync(email.ToUpperInvariant());
}