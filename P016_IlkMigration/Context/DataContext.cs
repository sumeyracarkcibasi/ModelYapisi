using Microsoft.EntityFrameworkCore;
using P016_IlkMigration.Models;

namespace P016_IlkMigration.Context
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Urun> Urun { get; set; }
  }
}
