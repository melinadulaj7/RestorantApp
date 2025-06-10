using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
namespace RestorantApp.Migrations
{
    /// <inheritdoc />
    /// <summary>
    /// Migration to remove the PaymentMethod column from the Orders table.
    /// </summary>
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}