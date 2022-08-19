using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace AccMng.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<TaxAuthority> TaxAuthorities { get; set; }
}