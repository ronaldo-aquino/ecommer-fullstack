using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Data
{
  public class MarketDbContext : DbContext
  {
    public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options) { }

    public DbSet<Produto> Produto { get; set; }

    public DbSet<Categoria> Categoria { get; set; }

    public DbSet<Marca> Marca { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}