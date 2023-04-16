using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTH19_03.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Student_Address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentAddress",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentAddress",
                table: "Students");
        }
    }
}
