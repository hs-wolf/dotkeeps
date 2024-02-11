using DotKeeps.Shared;
using Microsoft.EntityFrameworkCore;

namespace DotKeeps.Server.Data
{
  public class AppDbContext(IConfiguration Configuration) : DbContext
  {
    protected readonly IConfiguration _Configuration = Configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      options.UseNpgsql(_Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<KeepItem> KeepItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<KeepItem>(entity =>
      {
        entity.Property(e => e.Id).IsRequired();
        entity.Property(e => e.UserId).IsRequired();
        entity.Property(e => e.Type).IsRequired();
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.Season);
        entity.Property(e => e.Episode);
        entity.Property(e => e.Volume);
        entity.Property(e => e.Chapter);
        entity.Property(e => e.Link);
        entity.Property(e => e.CreatedAt);
        entity.Property(e => e.UpdatedAt);
      });
    }
  }
}