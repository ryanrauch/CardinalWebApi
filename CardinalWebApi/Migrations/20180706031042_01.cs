using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CardinalWebApi.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    TabId = table.Column<Guid>(nullable: false),
                    CardToken = table.Column<string>(nullable: true),
                    CurrentState = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    TimestampClosed = table.Column<DateTime>(nullable: false),
                    TimestampFinalized = table.Column<DateTime>(nullable: false),
                    TimestampOpened = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.TabId);
                });

            migrationBuilder.CreateTable(
                name: "TabHistories",
                columns: table => new
                {
                    TabHistoryId = table.Column<Guid>(nullable: false),
                    ActionText = table.Column<string>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    TabId = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabHistories", x => x.TabHistoryId);
                    table.ForeignKey(
                        name: "FK_TabHistories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabHistories_Tabs_TabId",
                        column: x => x.TabId,
                        principalTable: "Tabs",
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabLineItems",
                columns: table => new
                {
                    TabId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabLineItems", x => new { x.TabId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_TabLineItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabLineItems_Tabs_TabId",
                        column: x => x.TabId,
                        principalTable: "Tabs",
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabHistories_EmployeeId",
                table: "TabHistories",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TabHistories_TabId",
                table: "TabHistories",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_TabLineItems_ItemId",
                table: "TabLineItems",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabHistories");

            migrationBuilder.DropTable(
                name: "TabLineItems");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Tabs");
        }
    }
}
