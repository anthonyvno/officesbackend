using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend2.Migrations
{
    public partial class iniit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "City", "Email", "Latitude", "Longitude", "Name" },
                values: new object[] { new Guid("757a6811-0462-49c2-beed-1a5b562ca5f5"), "Ghent", "ghent@dundermifflin.com", 51.043475999999998, 3.7091379999999998, "Dunder Mifflin Ghent" });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "City", "Email", "Latitude", "Longitude", "Name" },
                values: new object[] { new Guid("5924c7d9-1289-4103-90ac-29cf1df64ce6"), "Kortrijk", "kortrijk@dundermifflin.com", 50.822955999999998, 3.2509619999999999, "Dunder Mifflin Kortrijk" });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "City", "Email", "Latitude", "Longitude", "Name" },
                values: new object[] { new Guid("af645f49-f884-4eb2-8eed-012e91865458"), "Harelbeke", "harelbeke@dundermifflin.com", 50.855365999999997, 3.3125529999999999, "Dunder Mifflin Harelbeke" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
