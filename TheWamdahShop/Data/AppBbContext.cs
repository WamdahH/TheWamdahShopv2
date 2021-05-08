﻿using TheWamdahShop.Models;
using Microsoft.EntityFrameworkCore;

namespace TheWamdahShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}