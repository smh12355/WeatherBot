using Microsoft.EntityFrameworkCore;
using System;
using WeatherBot.Domain.Customers;
using WeatherBot.Domain.Orders;

namespace WeatherBot.Application.Data;

public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; set; }

    DbSet<Order> Orders { get; set; }
}


