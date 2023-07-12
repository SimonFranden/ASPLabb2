using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPLabb2.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "FName",
                value: "Clark");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "FName",
                value: "Olof");
        }
    }
}
