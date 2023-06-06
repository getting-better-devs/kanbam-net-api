using Microsoft.Extensions.Configuration;

namespace Kanban.Domain.Extensions;

public static class RepositoryExtensions
{
    public static string GetDatabaseName(this IConfiguration configuration)
    {
        var databaseName = configuration.GetConnectionString("DatabaseName");

        return databaseName ?? string.Empty;
    }
    
    public static string GetConnectionString(this IConfiguration configuration)
    {
        var connection = configuration.GetConnectionString("Connection");

        return connection ?? string.Empty;
    }
    
    public static string GetCompleteConnectionString(this IConfiguration configuration)
    {
        var connection = configuration.GetConnectionString();
        var databaseName = configuration.GetDatabaseName();

        return $"{connection}Database={databaseName}";
    }
}