using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseStore.Infra.Data.Sql.Migrations
{
    public partial class KeyLessEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "PersonValueConvesions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PersonValueConvesions");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "PersonValueConvesions");

            migrationBuilder.CreateTable(
                name: "keyLessEntities",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "keyLessEntities");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "PersonValueConvesions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PersonValueConvesions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "PersonValueConvesions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
