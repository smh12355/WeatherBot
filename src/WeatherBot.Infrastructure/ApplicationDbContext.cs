using Microsoft.EntityFrameworkCore;
using System;
using WeatherBot.Application.Data;
using WeatherBot.Domain.Customers;
using WeatherBot.Domain.Orders;


namespace WeatherBot.Infrastructure;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql();
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
}


