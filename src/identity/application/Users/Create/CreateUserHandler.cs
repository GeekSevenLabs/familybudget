using FamilyBudget.Identity.Application.Services.Users;
using FamilyBudget.Identity.Application.Shared.Users.Create;
using FamilyBudget.Identity.Domain;
using FamilyBudget.Identity.Domain.Users;
using FamilyBudget.Identity.Domain.Users.ValueObjects;

namespace FamilyBudget.Identity.Application.Users.Create;

public class CreateUserHandler(
    IUserRepository repository, 
    IUserService userService,
    IIdentityUnitOfWork unitOfWork) : IHandler<CreateUserRequest>
{
    public async Task HandleAsync(CreateUserRequest request, CancellationToken cancellationToken = default)
    {
        Throw.When.NullOrWhiteSpace(request.Email);
        
        var user = await repository.GetByEmailAsync(request.Email);
        Throw.When.NotNull(user, "User with this email already exists.");
        
        var name = new NameVo(request.FirstName!, request.LastName!);
        var passwordHash = await userService.GeneratePasswordHashAsync(request.Password, cancellationToken);
        
        user = new User(name, request.Email, passwordHash);
        
        repository.Add(user);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}