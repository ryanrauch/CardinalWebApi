using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalWebApi.Models
{
    public class CardinalDbContext : DbContext
    {
        public CardinalDbContext(DbContextOptions<CardinalDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                        .HasKey(e => e.EmployeeId);

            modelBuilder.Entity<Item>()
                        .HasKey(i => i.ItemId);
            modelBuilder.Entity<Item>()
                        .Property(i => i.Price)
                        .IsRequired();

            modelBuilder.Entity<TabHistory>()
                        .HasKey(t => t.TabHistoryId);
            //all other prop req

            modelBuilder.Entity<Tab>()
                        .HasKey(t => t.TabId);

            modelBuilder.Entity<TabLineItem>()
                        .HasKey(t => new { t.TabId, t.Order });
            modelBuilder.Entity<TabLineItem>()
                        .Property(t => t.Order)
                        .ValueGeneratedOnAdd();

            //tablineitem.Item and .Quantity req

            //modelBuilder.Entity<TabLineItem>()
            //            .HasOne(t => t.Item)
            //            .WithMany();

            //modelBuilder.Entity<TabLineItem>()
            //            .HasOne(t => t.Tab)
            //            .WithMany();
            //modelBuilder.Entity<Tab>()
            //            .HasMany(t => t.Items)
            //            .WithOne();

            //modelBuilder.Entity<TabHistory>()
            //            .HasOne(t => t.Tab)
            //            .WithOne()
            //            .HasForeignKey(k => k.TabId);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<TabLineItem> TabLineItems { get; set; }
        public DbSet<TabHistory> TabHistories { get; set; }
    }
}
