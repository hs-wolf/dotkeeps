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
  }
}