using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Infrastructure.Migrations
{
    public partial class withdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "Email", "Gender", "Name" },
                values: new object[] { -1, 30, "vincent.dagpiN@gmail.com", (byte)1, "Vincent" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
