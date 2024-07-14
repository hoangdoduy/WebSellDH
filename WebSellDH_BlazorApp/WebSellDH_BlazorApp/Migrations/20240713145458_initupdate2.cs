using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSellDH_BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class initupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductLinkName",
                table: "ProductLinks",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductLinkName",
                table: "ProductLinks");
        }
    }
}
