using Microsoft.EntityFrameworkCore;
using MVSRA.Shared.EFModels;

namespace MVSRA.Server.EFContext;

public class MVSRAContext(DbContextOptions<MVSRAContext> options) : DbContext(options)
{
    public DbSet<Photo> Photos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("MVSRA");
    }
}
