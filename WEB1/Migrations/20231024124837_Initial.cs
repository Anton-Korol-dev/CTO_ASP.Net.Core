using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEB1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.PhoneNumber);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: true),
                    Worker_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type_of_Worker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "PhoneNumber", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { "0668910456", "Kyrylo", "Kalushenko", "Volodymyrovich" },
                    { "0937842857", "Mykola", "Pron", "Victorych" },
                    { "0971565481", "Denys", "Petrushchenko", "Serhiyovych" }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "ID", "Adress", "Experience", "FirstName", "LastName", "MiddleName", "Salary", "Type_of_Worker", "Worker_Phone_Number" },
                values: new object[] { "389d2f71-7d1f-421a-a630-8c38a67615a5", null, null, "Mykhailo", "Hlevatsky", "Andriiovych", null, null, "0989381314" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
