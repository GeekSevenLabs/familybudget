using FamilyBudget.Identity.Domain.Users;
using FamilyBudget.Identity.Domain.Users.ValueObjects;

namespace FamilyBudget.Identity.Tests.Domain.Users;

public class UserTests
{
    [Fact]
    public void GivenPasswordHashIsEmptyWhenCreatingUserThenThrowsException()
    {
        // Arrange
        const string passwordHash = "";
        const string email = "mail@domain.com";
        NameVo name = new ("John", "Doe");
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new User(name, email, passwordHash));
    }

    [Fact]
    public void GivenValidParametersWhenCreatingUserThenUserIsCreated()
    {
        // Arrange
        const string passwordHash = "validHash";
        const string email = "mail@domain.com";
        NameVo name = new("John", "Doe");

        // Act
        User user = new(name, email, passwordHash);

        // Assert
        Assert.NotNull(user);
        Assert.Equal(name, user.Name);
        Assert.Equal(email, user.Email);
        Assert.Equal(passwordHash, user.PasswordHash);
    }
}