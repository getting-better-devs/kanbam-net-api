using Kanban.Domain.Extensions;
using Kanban.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kanban.Infrastructure;

public static class Bootstrapper
{
    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        AddContext(services, configuration);
    }
    
    private static void AddContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetCompleteConnectionString();

        services.AddDbContext<Context>(options =>
        {
            options.UseNpgsql(connectionString);
        });
    }
}