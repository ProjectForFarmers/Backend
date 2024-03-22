﻿using FarmersMarketplace.Domain;
using Microsoft.EntityFrameworkCore;
using DayOfWeek = FarmersMarketplace.Domain.DayOfWeek;

namespace FarmersMarketplace.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Farm> Farms { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<DayOfWeek> DaysOfWeek { get; set; }
        DbSet<Schedule> Schedules { get; set; }
        DbSet<MonthStatistic> MonthesStatistics { get; set; }
        DbSet<OrderItem> OrdersItems { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Subcategory> Subcategories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProducerPaymentData> PaymentData { get; set; }
        DbSet<FarmLog> FarmsLogs { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
        Task<int> SaveChangesAsync();
    }
}
