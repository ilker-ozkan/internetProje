﻿using Microsoft.EntityFrameworkCore;

namespace Internet_1.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<CartItem> CartItems { get; set; } // Sepet öğelerini tutan DbSet ekleme. Unutmamak için Not




        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
