using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitorWebApi.Migrations
{
    public partial class DocTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Visitors",
                newName: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_DoctorId",
                table: "Visitors",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitors_Doctors_DoctorId",
                table: "Visitors",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_Doctors_DoctorId",
                table: "Visitors");

            migrationBuilder.DropIndex(
                name: "IX_Visitors_DoctorId",
                table: "Visitors");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Visitors",
                newName: "GroupId");
        }
    }
}
