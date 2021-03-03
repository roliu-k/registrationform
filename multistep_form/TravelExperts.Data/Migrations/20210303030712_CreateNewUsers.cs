using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelExperts.Data.Migrations
{
    public partial class CreateNewUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustFirstName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CustLastName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CustAddress = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CustCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustProv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustHomePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustBusPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentId = table.Column<int>(type: "int", nullable: true),
                    UserLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
