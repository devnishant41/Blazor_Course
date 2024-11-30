using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App_01_ServerManagement.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ServerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ServerId);
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "ServerId", "City", "IsOnline", "Name" },
                values: new object[,]
                {
                    { 1, "New York", false, "SRV-NYC-01" },
                    { 2, "London", true, "SRV-LAX-01" },
                    { 3, "Chicago", true, "SRV-CHI-01" },
                    { 4, "London", false, "SRV-LON-01" },
                    { 5, "Tokyo", false, "SRV-TKY-01" },
                    { 6, "London", false, "SRV-SYD-01" },
                    { 7, "Chicago", false, "SRV-SIN-01" },
                    { 8, "Chicago", false, "SRV-FRA-01" },
                    { 9, "Chicago", false, "SRV-TOR-01" },
                    { 10, "London", true, "SRV-AMS-01" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}
