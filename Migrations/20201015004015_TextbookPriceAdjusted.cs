using Microsoft.EntityFrameworkCore.Migrations;

namespace TextbookFinder.Migrations
{
    public partial class TextbookPriceAdjusted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Textbooks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Textbooks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
