using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitorWebApi.Migrations
{
    public partial class TableVisPass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Visitors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Visitors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Visitors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Visitors");
        }
    }
}
