using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPLabb2.Migrations
{
    /// <inheritdoc />
    public partial class AddedCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseName", "TeacherId" },
                values: new object[] { "Programmering 2", 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseName", "TeacherId" },
                values: new object[] { "Fysik", 1 });
        }
    }
}
