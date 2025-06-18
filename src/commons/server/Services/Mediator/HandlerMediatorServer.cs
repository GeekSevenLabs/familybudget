using FamilyBudget.Common.Handlers;

namespace FamilyBudget.Common.Services.Mediator;

public class HandlerMediatorServer(IRequestProvider provider) : IHandlerMediator
{
    public Task SendAsync<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest
    {
        throw new NotImplementedException();
    }

    public Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest<TResponse>
    {
        throw new NotImplementedException();
    }
}