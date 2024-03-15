﻿using application.Shared.Models.Test;
using Microsoft.EntityFrameworkCore;

namespace application.Shared.Data
{
    public class SqlContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CentralDB;Trusted_Connection=true;");
        }

    }
}
