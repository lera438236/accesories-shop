using Microsoft.EntityFrameworkCore;
using Practic.Models;

namespace Practic;

public class AplicationContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Practic;Username=postgres;Password=1"); 
        public DbSet<brands> Brands { get; set; }
        public DbSet<category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<clients> Clients { get; set; }
        public DbSet<comments>Comments { get; set; }
        public DbSet<order> Orders { get; set; }
        public DbSet<products> Products { get; set; }
        public DbSet<subcategory> Subcategories { get; set; }
}