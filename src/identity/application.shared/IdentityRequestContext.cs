using FamilyBudget.Identity.Application.Shared.Users.Create;

namespace FamilyBudget.Identity.Application.Shared;

public class IdentityRequestContext : IRequestContext
{
    public static void ConfigureRequests(IRequestRegistry registry)
    {
        registry.RegisterWithValidator<CreateUserRequest, CreateUserValidator>(builder =>
        {
            builder
                .MapPost("/users")
                .WithRequiredAuthentication();
        });
    }
}