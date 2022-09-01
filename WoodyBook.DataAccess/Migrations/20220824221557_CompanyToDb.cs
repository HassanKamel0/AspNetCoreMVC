using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodyBooks.Migrations
{
    public partial class CompanyToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Postal",
                table: "Companies",
                newName: "PostalCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Companies",
                newName: "Postal");
        }
    }
}
