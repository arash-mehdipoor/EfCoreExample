using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseStore.Infra.Data.Sql.Migrations
{
    public partial class NationalCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "PersonValueConvesions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "PersonValueConvesions");
        }
    }
}
