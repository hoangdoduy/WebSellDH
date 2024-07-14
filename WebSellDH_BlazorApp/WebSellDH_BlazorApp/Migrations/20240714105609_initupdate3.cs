using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSellDH_BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class initupdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "UserAccounts",
                type: "decimal(18,0)",
                precision: 18,
                scale: 0,
                nullable: true,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,8)",
                oldPrecision: 18,
                oldNullable: true,
                oldDefaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "UserAccounts",
                type: "decimal(18,8)",
                precision: 18,
                nullable: true,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18,
                oldScale: 0,
                oldNullable: true,
                oldDefaultValue: 0m);
        }
    }
}
