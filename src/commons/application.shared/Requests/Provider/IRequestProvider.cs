// ReSharper disable once CheckNamespace
namespace FamilyBudget.Common;

public interface IRequestProvider
{
    HandlerRequestDefinition GetRequiredDefinition<TRequest>() where TRequest : IRequest;
    
    internal void AddDefinition<TRequest>(HandlerRequestDefinition definition) where TRequest : IRequest;
}