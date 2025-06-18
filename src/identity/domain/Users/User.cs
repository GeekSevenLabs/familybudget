using FamilyBudget.Identity.Domain.Users.ValueObjects;

namespace FamilyBudget.Identity.Domain.Users;

public class User : Entity, IAggregateRoot
{
    public User(NameVo name, string email, string passwordHash)
    {
        Throw.When.NullOrWhiteSpace(passwordHash, "Password hash cannot be null or empty.");
        Throw.When.InvalidEmail(email, "Email is not valid.");
        
        Name = name;
        
        Email = email.ToUpperInvariant();
        EmailConfirmed = false;
        
        PasswordHash = passwordHash;
    }
    
    public NameVo Name { get; private set; }
    
    public string Email { get; private set; }
    public bool EmailConfirmed { get; private set; }
    
    public string PasswordHash { get; private set; }
    
}