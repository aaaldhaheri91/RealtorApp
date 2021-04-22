using Microsoft.EntityFrameworkCore.Migrations;

namespace RealtorApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    YearBuilt = table.Column<int>(nullable: false),
                    PropertyType = table.Column<string>(nullable: true),
                    SquareFeet = table.Column<int>(nullable: false),
                    Bedrooms = table.Column<int>(nullable: false),
                    Bathrooms = table.Column<double>(nullable: false),
                    GarageCapacity = table.Column<double>(nullable: false),
                    RelatorName = table.Column<string>(nullable: true),
                    RelatorPhone = table.Column<string>(nullable: true),
                    RelatorEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
