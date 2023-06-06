using Microsoft.EntityFrameworkCore;

namespace Kanban.Infrastructure.Database;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
    }
}