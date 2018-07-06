﻿// <auto-generated />
using System;
using CardinalWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardinalWebApi.Migrations
{
    [DbContext(typeof(CardinalDbContext))]
    partial class CardinalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CardinalWebApiLibrary.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PinCode");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.Item", b =>
                {
                    b.Property<Guid>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<Guid>("ItemGroupId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ItemId");

                    b.HasIndex("ItemGroupId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.ItemGroup", b =>
                {
                    b.Property<Guid>("ItemGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("ItemGroupId");

                    b.ToTable("ItemGroups");
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.Tab", b =>
                {
                    b.Property<Guid>("TabId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardToken");

                    b.Property<int>("CurrentState");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("TimestampClosed");

                    b.Property<DateTime>("TimestampFinalized");

                    b.Property<DateTime>("TimestampOpened");

                    b.HasKey("TabId");

                    b.ToTable("Tabs");
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.TabHistory", b =>
                {
                    b.Property<Guid>("TabHistoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionText")
                        .IsRequired();

                    b.Property<Guid>("EmployeeId");

                    b.Property<Guid>("TabId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("TabHistoryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TabId");

                    b.ToTable("TabHistories");
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.TabItem", b =>
                {
                    b.Property<Guid>("TabId");

                    b.Property<Guid>("ItemId");

                    b.Property<int>("Quantity");

                    b.HasKey("TabId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("TabItems");
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.Item", b =>
                {
                    b.HasOne("CardinalWebApiLibrary.Models.ItemGroup", "ItemGroup")
                        .WithMany()
                        .HasForeignKey("ItemGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.TabHistory", b =>
                {
                    b.HasOne("CardinalWebApiLibrary.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CardinalWebApiLibrary.Models.Tab", "Tab")
                        .WithMany()
                        .HasForeignKey("TabId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardinalWebApiLibrary.Models.TabItem", b =>
                {
                    b.HasOne("CardinalWebApiLibrary.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CardinalWebApiLibrary.Models.Tab", "Tab")
                        .WithMany()
                        .HasForeignKey("TabId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
