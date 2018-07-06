using CardinalWebApiLibrary.Models;
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
            modelBuilder.Entity<Item>()
                        .Property(i => i.Description)
                        .IsRequired();

            modelBuilder.Entity<Tab>()
                        .HasKey(t => t.TabId);

            modelBuilder.Entity<TabItem>()
                        .HasKey(t => new { t.TabId, t.ItemId });
            modelBuilder.Entity<TabItem>()
                        .HasOne(t => t.Tab)
                        .WithMany()
                        .HasForeignKey("TabId");
            modelBuilder.Entity<TabItem>()
                        .HasOne(t => t.Item)
                        .WithMany()
                        .HasForeignKey("ItemId");
            modelBuilder.Entity<TabItem>()
                        .Property(t => t.Quantity)
                        .IsRequired();


            modelBuilder.Entity<TabHistory>()
                        .HasKey(t => t.TabHistoryId);
            modelBuilder.Entity<TabHistory>()
                        .HasOne(t => t.Tab)
                        .WithMany()
                        .HasForeignKey("TabId");
            modelBuilder.Entity<TabHistory>()
                        .HasOne(t => t.Employee)
                        .WithMany()
                        .HasForeignKey("EmployeeId");
            modelBuilder.Entity<TabHistory>()
                        .Property(t => t.Timestamp)
                        .IsRequired();
            modelBuilder.Entity<TabHistory>()
                        .Property(t => t.ActionText)
                        .IsRequired();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<TabItem> TabLineItems { get; set; }
        public DbSet<TabHistory> TabHistories { get; set; }
    }
}
