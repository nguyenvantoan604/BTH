using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTH19_03.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Persion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persions",
                columns: table => new
                {
                    PersionID = table.Column<string>(type: "TEXT", nullable: false),
                    PersionName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persions", x => x.PersionID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persions");
        }
    }
}
