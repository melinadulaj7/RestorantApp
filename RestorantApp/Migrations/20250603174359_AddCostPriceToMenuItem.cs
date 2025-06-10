using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestorantApp.Migrations
{
    public partial class AddCostPriceToMEnuItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Heq kolonën PaymentMethod nga tabela Orders
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Nëse duam të rikthejmë migracionin, shtojmë përsëri kolonën
            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}