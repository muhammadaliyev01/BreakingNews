using BreakingNews.Service.Interfaces.Accounts;
using BreakingNews.Service.Interfaces.Common;
using BreakingNews.Service.Interfaces.Products;
using BreakingNews.Service.Services.Accounts;
using BreakingNews.Service.Services.Common;
using BreakingNews.Service.Services.Products;

namespace BreakingNews.Web.Configurations.LayerConfigurations;
public static class ServiceLayerConfiguration
{
    public static void AddService(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<INewService, NewService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IIdentityService, IdentityService>();
    }
}
