using Microsoft.EntityFrameworkCore.Migrations;

namespace Todoapi.Migrations
{
    public partial class removecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Albums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Artist",
                table: "Albums",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
