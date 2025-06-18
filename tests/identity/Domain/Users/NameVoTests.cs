using FamilyBudget.Identity.Domain.Users.ValueObjects;

namespace FamilyBudget.Identity.Tests.Domain.Users;

public class NameVoTests
{
    [Fact]
    public void GivenValidNamesWhenCreatedThenShouldReturnFullName()
    {
        // Arrange
        const string firstName = "John";
        const string lastName = "Doe";
        const string expectedFullName = "John Doe";

        // Act
        var name = new NameVo(firstName, lastName);
        
        // Assert
        Assert.Equal(expectedFullName, name.FullName);
        Assert.Equal(expectedFullName, name.ToString());
    }
    
    [Fact]
    public void GivenEmptyFirstNameWhenCreatingThenShouldException()
    {
        // Arrange
        const string firstName = "";
        const string lastName = "Doe";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new NameVo(firstName, lastName));
    }
    
    [Fact]
    public void GivenEmptyLastNameWhenCreatingThenShouldException()
    {
        // Arrange
        const string firstName = "John";
        const string lastName = "";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new NameVo(firstName, lastName));
    }
    
    [Fact]
    public void GivenNullFirstNameWhenCreatingThenShouldException()
    {
        // Arrange
        const string? firstName = null;
        const string lastName = "Doe";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new NameVo(firstName!, lastName));
    }
    
    [Fact]
    public void GivenNullLastNameWhenCreatingThenShouldException()
    {
        // Arrange
        const string firstName = "John";
        const string? lastName = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new NameVo(firstName, lastName!));
    }
}