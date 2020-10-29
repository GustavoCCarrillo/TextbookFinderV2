using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TextbookFinder.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Author_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_name = table.Column<string>(maxLength: 100, nullable: false),
                    Last_name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Author_id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categories = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Address1 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    GiftWrap = table.Column<bool>(nullable: false),
                    Shipped = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Textbook_Publishers",
                columns: table => new
                {
                    Publisher_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Publisher_name = table.Column<string>(maxLength: 200, nullable: false),
                    Publisher_website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textbook_Publishers", x => x.Publisher_id);
                });

            migrationBuilder.CreateTable(
                name: "Textbooks",
                columns: table => new
                {
                    Textbook_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Edition = table.Column<string>(maxLength: 5, nullable: true),
                    Isbn = table.Column<string>(maxLength: 50, nullable: true),
                    Published_date = table.Column<DateTime>(type: "date", nullable: true),
                    Publisher_id = table.Column<int>(nullable: true),
                    Category_id = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textbooks", x => x.Textbook_id);
                    table.ForeignKey(
                        name: "FK_Category",
                        column: x => x.Category_id,
                        principalTable: "Category",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Texbook_Publisher",
                        column: x => x.Publisher_id,
                        principalTable: "Textbook_Publishers",
                        principalColumn: "Publisher_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartLine",
                columns: table => new
                {
                    CartLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextbookId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLine", x => x.CartLineID);
                    table.ForeignKey(
                        name: "FK_CartLine_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLine_Textbooks_TextbookId",
                        column: x => x.TextbookId,
                        principalTable: "Textbooks",
                        principalColumn: "Textbook_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Textbook_Authors",
                columns: table => new
                {
                    Textbook_id = table.Column<int>(nullable: false),
                    Author_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textbook_Authors", x => new { x.Textbook_id, x.Author_id });
                    table.ForeignKey(
                        name: "FK_Author_id",
                        column: x => x.Author_id,
                        principalTable: "Authors",
                        principalColumn: "Author_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Texbooks",
                        column: x => x.Textbook_id,
                        principalTable: "Textbooks",
                        principalColumn: "Textbook_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Textbook_Categories",
                columns: table => new
                {
                    Textbook_id = table.Column<int>(nullable: false),
                    Category_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textbook_Categories", x => new { x.Textbook_id, x.Category_id });
                    table.ForeignKey(
                        name: "FK_Categories",
                        column: x => x.Category_id,
                        principalTable: "Category",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Texbooks_Categories",
                        column: x => x.Textbook_id,
                        principalTable: "Textbooks",
                        principalColumn: "Textbook_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_OrderId",
                table: "CartLine",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_TextbookId",
                table: "CartLine",
                column: "TextbookId");

            migrationBuilder.CreateIndex(
                name: "IX_Textbook_Authors_Author_id",
                table: "Textbook_Authors",
                column: "Author_id");

            migrationBuilder.CreateIndex(
                name: "IX_Textbook_Categories_Category_id",
                table: "Textbook_Categories",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Textbooks_Category_id",
                table: "Textbooks",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Textbooks_Publisher_id",
                table: "Textbooks",
                column: "Publisher_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLine");

            migrationBuilder.DropTable(
                name: "Textbook_Authors");

            migrationBuilder.DropTable(
                name: "Textbook_Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Textbooks");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Textbook_Publishers");
        }
    }
}
