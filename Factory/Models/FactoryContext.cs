using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Licenses> Licenses { get; set; }
    pubic FactoryContext(DbContextOptions options) : base(options) { }
  }
}