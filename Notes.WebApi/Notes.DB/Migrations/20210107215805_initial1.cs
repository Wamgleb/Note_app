using Microsoft.EntityFrameworkCore.Migrations;

namespace Notes.DB.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valur",
                table: "Notes",
                newName: "Value");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Notes",
                newName: "Valur");
        }
    }
}
