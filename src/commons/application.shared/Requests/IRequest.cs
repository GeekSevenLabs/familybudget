// ReSharper disable once CheckNamespace
namespace FamilyBudget.Common;

public interface IRequest;

public interface IRequest<out TResponse> : IRequest;