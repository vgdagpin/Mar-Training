using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Infrastructure.Migrations
{
    public partial class withlogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LoginHistory",
                columns: new[] { "ID", "LoginDate", "UserID" },
                values: new object[] { -1, new DateTime(2020, 4, 3, 22, 4, 21, 885, DateTimeKind.Local).AddTicks(318), -1 });

            migrationBuilder.InsertData(
                table: "LoginHistory",
                columns: new[] { "ID", "LoginDate", "UserID" },
                values: new object[] { -2, new DateTime(2020, 4, 3, 22, 4, 21, 887, DateTimeKind.Local).AddTicks(3961), -1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoginHistory",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "LoginHistory",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
