using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoxSchool.Migrations
{
    /// <inheritdoc />
    public partial class removedFkKeysEnrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FkCourseId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "FkStudentId",
                table: "Enrollments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FkCourseId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FkStudentId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
