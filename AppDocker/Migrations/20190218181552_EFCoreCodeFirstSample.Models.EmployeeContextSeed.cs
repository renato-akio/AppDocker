using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDocker.Migrations
{
    public partial class AppDockerModelsEmployeeContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1L, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "teste@teste.com", "Primeiro", "Teste", "999-888-7777" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2L, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "teste2@teste2.com", "Segundo", "Teste", "111-222-3333" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2L);
        }
    }
}
