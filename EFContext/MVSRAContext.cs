using Microsoft.EntityFrameworkCore;
using MVSRA.EFModels;

namespace MVSRA.EFContext;

public class MVSRAContext(DbContextOptions<MVSRAContext> options) : DbContext(options)
{
    public DbSet<Photo> Photos { get; set; }
}
