// ReSharper disable once CheckNamespace
namespace FamilyBudget.Common;

public interface IRequestContext
{
    public static abstract void ConfigureRequests(IRequestRegistry registry);
}