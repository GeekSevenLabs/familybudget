using FamilyBudget.Identity.Application.Shared.Users.Create;
using FamilyBudget.Identity.Application.Users.Create;

namespace FamilyBudget.Identity.Application;

public class IdentityHandlersContext : IHandlersContext
{
    public static void ConfigureHandlers(IHandlerRegistry registry)
    {
        registry.Register<CreateUserHandler, CreateUserRequest>();
    }
}