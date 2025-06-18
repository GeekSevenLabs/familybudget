// ReSharper disable once CheckNamespace
namespace FamilyBudget.Common;

public interface IServicesContext
{
    public static abstract void ConfigureServices(IServiceCollection services, IConfiguration configuration);
}