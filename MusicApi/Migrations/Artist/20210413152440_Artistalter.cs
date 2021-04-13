using Microsoft.EntityFrameworkCore.Migrations;

namespace Todoapi.Migrations.Artist
{
    public partial class Artistalter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Artists",
                newName: "Debutdate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Debutdate",
                table: "Artists",
                newName: "Birthdate");
        }
    }
}
