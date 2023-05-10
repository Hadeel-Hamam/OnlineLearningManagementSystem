using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningManagementSystemProject.Migrations
{
    public partial class lastMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Staffs_StaffId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StaffId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StaffId",
                table: "Courses",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Staffs_StaffId",
                table: "Courses",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "StaffId");
        }
    }
}
