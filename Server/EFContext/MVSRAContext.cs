using Microsoft.EntityFrameworkCore;
using MVSRA.Shared.EFModels;

namespace MVSRA.Server.EFContext;

public class MVSRAContext(DbContextOptions<MVSRAContext> options) : DbContext(options)
{
    public DbSet<HotInfo> HotInfo { get; set; }
    public DbSet<League> Leagues { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Officer> Officers { get; set; }

    public DbSet<Photo> Photos { get; set; }
    public DbSet<HomePagePhoto> HomePagePhotos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("MVSRA");

        modelBuilder.Entity<Location>()
            .HasMany(x => x.Photos)
            .WithMany(x => x.Locations)
            .UsingEntity("PhotoGallery_Locations");
    }
}
