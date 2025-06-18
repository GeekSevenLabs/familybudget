// ReSharper disable once CheckNamespace
namespace FamilyBudget.Common;

public interface IHandlersContext
{
    public static abstract void ConfigureHandlers(IHandlerRegistry registry);
}