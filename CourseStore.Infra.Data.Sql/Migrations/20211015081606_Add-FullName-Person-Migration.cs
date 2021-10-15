using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace CourseStore.Infra.Data.Sql.Migrations
{

    public static class MigrationExtention
    {
        public static OperationBuilder<SqlOperation> CreateUser(this MigrationBuilder builder, string name)
        {
            return builder.Sql($"Create User {name}");
        }

        public static OperationBuilder<CreateUserOperation> CreateUserOperation(this MigrationBuilder builder, string name, string password)
        {
            var operation = new CreateUserOperation()
            {
                Name = name,
                Password = password
            };

            builder.Operations.Add(operation);
            return new OperationBuilder<CreateUserOperation>(operation);
        }
    }

    public class CreateUserOperation : MigrationOperation
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public partial class AddFullNamePersonMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>("FullName", "People", type: "nvarchar(max)", nullable: true);

            migrationBuilder.Sql("Update People Set FullName = Name + ', ' + LastName");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "People");

            migrationBuilder.DropColumn(
               name: "Name",
               table: "People");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("Name", "People", type: "nvarchar(max)", nullable: true);
            migrationBuilder.AddColumn<string>("LastName", "People", type: "nvarchar(max)", nullable: true);


            migrationBuilder.Sql("Update People Set Name = SELECT FullName FROM People('FullName', ' ')");
            migrationBuilder.Sql("Update People Set LastName = SELECT FullName FROM People('FullName', ' ')");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "People");
        }
    }
}
