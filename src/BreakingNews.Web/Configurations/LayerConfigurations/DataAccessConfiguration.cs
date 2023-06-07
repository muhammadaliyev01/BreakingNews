using BreakingNews.DataAccess.DbContexts;
using BreakingNews.DataAccess.Interfaces;
using BreakingNews.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BreakingNews.Web.Configurations.LayerConfigurations;
public static class DataAccessConfiguration
{
    public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("DatabaseConnection")!;
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
