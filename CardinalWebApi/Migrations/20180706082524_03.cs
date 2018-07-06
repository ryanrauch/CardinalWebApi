using Microsoft.EntityFrameworkCore.Migrations;

namespace CardinalWebApi.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabLineItems_Items_ItemId",
                table: "TabLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TabLineItems_Tabs_TabId",
                table: "TabLineItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TabLineItems",
                table: "TabLineItems");

            migrationBuilder.RenameTable(
                name: "TabLineItems",
                newName: "TabItems");

            migrationBuilder.RenameIndex(
                name: "IX_TabLineItems_ItemId",
                table: "TabItems",
                newName: "IX_TabItems_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TabItems",
                table: "TabItems",
                columns: new[] { "TabId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TabItems_Items_ItemId",
                table: "TabItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TabItems_Tabs_TabId",
                table: "TabItems",
                column: "TabId",
                principalTable: "Tabs",
                principalColumn: "TabId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabItems_Items_ItemId",
                table: "TabItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TabItems_Tabs_TabId",
                table: "TabItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TabItems",
                table: "TabItems");

            migrationBuilder.RenameTable(
                name: "TabItems",
                newName: "TabLineItems");

            migrationBuilder.RenameIndex(
                name: "IX_TabItems_ItemId",
                table: "TabLineItems",
                newName: "IX_TabLineItems_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TabLineItems",
                table: "TabLineItems",
                columns: new[] { "TabId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TabLineItems_Items_ItemId",
                table: "TabLineItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TabLineItems_Tabs_TabId",
                table: "TabLineItems",
                column: "TabId",
                principalTable: "Tabs",
                principalColumn: "TabId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
