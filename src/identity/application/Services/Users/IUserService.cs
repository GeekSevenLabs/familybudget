using FamilyBudget.Identity.Domain.Users;

namespace FamilyBudget.Identity.Application.Services.Users;

public interface IUserService
{
    Task<string> GeneratePasswordHashAsync(string? password, CancellationToken cancellationToken = default);
    Task<bool> VerifyPasswordAsync(User user, string? password, CancellationToken cancellationToken = default);
}