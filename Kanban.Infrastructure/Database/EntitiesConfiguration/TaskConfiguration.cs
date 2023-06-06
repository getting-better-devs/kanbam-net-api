using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = Kanban.Domain.Entities.Task;

namespace Kanban.Infrastructure.Database.EntitiesConfiguration;

public class TaskConfiguration : IEntityTypeConfiguration<Task>
{
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        builder.ToTable(nameof(Task));

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}