using Microsoft.AspNetCore.Builder;

// ReSharper disable once CheckNamespace
namespace FamilyBudget.Common;

public static class HandlerRequestServerExtensions
{
    extension(IServiceCollection services) 
    {
        public void AddHandlerRequestServicesForServer(
            Action<IRequestRegistry>[] requestRegistries,
            Action<IHandlerRegistry>[] handlerRegistries,
            Action<IServiceCollection>[] serviceRegistries)
        {
            services.AddRequests(requestRegistries);
            services.AddHandlers(handlerRegistries);
            services.AddServices(serviceRegistries);
        }

        private void AddRequests(params Action<IRequestRegistry>[] registries)
        {
            var provider = RequestProvider.Empty;
            var registry = new RequestRegistry(provider, services);
            
            foreach (var registryAction in registries)
            {
                registryAction(registry);
            }
            
            services.AddSingleton<IRequestProvider>(provider);
        }
        
        private void AddHandlers(params Action<IHandlerRegistry>[] registries)
        {
            var handlerRegistry = new HandlerRegistryService(services);
            foreach (var registryAction in registries)
            {
                registryAction(handlerRegistry);
            }
        }
        
        private void AddServices(params Action<IServiceCollection>[] registries)
        {
            foreach (var registryAction in registries)
            {
                registryAction(services);
            }
        }
    }

    extension(WebApplication app)
    {
        public void MapHandlerRequestEndpoints(Action<IHandlerRegistry>[] handlerRegistries, string basePath = "/api")
        {
            var provider = app.Services.GetRequiredService<IRequestProvider>();
            var baseEndpoint = app.MapGroup(basePath);
            
            var handlerRegistry = new HandlerRegistryEndpoint(provider, baseEndpoint);
            
            foreach (var registryAction in handlerRegistries)
            {
                registryAction(handlerRegistry);
            }
        }
    }
}