using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamRoomV2Client.DataAccess.Migrations
{
    public partial class RolesSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2304998e-3456-4468-b0e6-398f6e662f7a", "7", "Professor", "Professor" },
                    { "259047a3-4e62-4411-b768-25f18f2780e4", "2", "User", "User" },
                    { "733ca019-f7d9-4bf3-a0b9-13bf0ec11a3d", "1", "Admin", "Admin" },
                    { "bcd5ce53-e06e-4d79-bbfc-2a8d4a0d8818", "4", "Subject Head", "Subject Head" },
                    { "c3f3552d-1e47-478f-a64b-5f464efe42ad", "6", "Invigilator", "Invigilator" },
                    { "d3a43287-9b6c-4f0a-8582-255f43024c3c", "3", "HR", "HR" },
                    { "da6a9815-795a-4943-96b6-7ddd03190fe5", "5", "Faculty Head", "Faculty Head" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2304998e-3456-4468-b0e6-398f6e662f7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "259047a3-4e62-4411-b768-25f18f2780e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "733ca019-f7d9-4bf3-a0b9-13bf0ec11a3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd5ce53-e06e-4d79-bbfc-2a8d4a0d8818");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f3552d-1e47-478f-a64b-5f464efe42ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3a43287-9b6c-4f0a-8582-255f43024c3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da6a9815-795a-4943-96b6-7ddd03190fe5");
        }
    }
}
