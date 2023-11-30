using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitorWebApi.Migrations
{
    public partial class TableDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Visitors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Visitors");
        }
    }
}
