
namespace FamilyBudget.Identity.Domain.Users.ValueObjects;

public readonly record struct NameVo
{
    public NameVo(string first, string last)
    {
        Throw.When.NullOrWhiteSpace(first, "First name cannot be null or empty.");
        Throw.When.NullOrWhiteSpace(last, "Last name cannot be null or empty.");
        
        First = first;
        Last = last;
    }

    public string First { get; init; }
    public string Last { get; init; }
    
    public string FullName => $"{First} {Last}";

    public override string ToString() => FullName;
}