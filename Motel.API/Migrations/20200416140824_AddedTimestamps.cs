using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.API.Migrations
{
    public partial class AddedTimestamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ref",
                value: new Guid("7de2e2f4-a392-4897-81e9-9b2c36d91b5c"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ref",
                value: new Guid("2fcbff7b-12dc-4224-81ab-12d0faa0316c"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Ref",
                value: new Guid("480c5b4b-c894-4a9e-b040-668f591dc308"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { new byte[] { 92, 12, 31, 101, 211, 95, 125, 32, 151, 166, 7, 85, 48, 87, 248, 219, 70, 44, 12, 148, 184, 80, 112, 218, 187, 250, 208, 209, 86, 161, 253, 102, 204, 214, 44, 28, 183, 159, 26, 180, 73, 246, 147, 170, 44, 51, 221, 113, 137, 36, 62, 183, 105, 127, 43, 183, 110, 247, 131, 44, 114, 181, 249, 144 }, new byte[] { 78, 89, 235, 142, 68, 170, 92, 188, 160, 167, 133, 230, 193, 97, 200, 15, 95, 44, 124, 83, 53, 197, 41, 63, 251, 141, 171, 163, 67, 249, 174, 202, 43, 6, 162, 197, 6, 36, 135, 207, 124, 153, 115, 69, 112, 66, 204, 250, 201, 78, 60, 127, 98, 193, 8, 255, 157, 155, 6, 143, 89, 207, 14, 2, 161, 160, 240, 132, 211, 26, 48, 81, 231, 67, 39, 72, 87, 172, 229, 108, 58, 12, 195, 252, 45, 79, 82, 180, 144, 103, 217, 169, 171, 39, 235, 70, 224, 7, 109, 59, 68, 16, 89, 190, 193, 33, 91, 237, 126, 227, 180, 168, 171, 255, 71, 185, 193, 109, 79, 198, 244, 60, 180, 158, 18, 215, 182, 198 }, new Guid("fb7b84c2-fbb6-48bd-b535-60c789f1ff86") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ref",
                value: new Guid("dbcff082-70d8-4b71-abf9-0ba88f226e59"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ref",
                value: new Guid("e91618a6-db23-4719-8df3-e79ad624d9b0"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Ref",
                value: new Guid("5b6a50cd-61c4-49db-8dc6-7994c474061d"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { new byte[] { 28, 134, 162, 225, 83, 8, 129, 60, 199, 113, 104, 134, 17, 231, 74, 100, 81, 170, 46, 182, 215, 204, 21, 54, 22, 15, 101, 201, 67, 208, 9, 205, 0, 76, 72, 158, 179, 89, 255, 91, 84, 64, 183, 194, 122, 47, 249, 57, 136, 36, 120, 194, 158, 37, 102, 155, 149, 215, 147, 7, 10, 115, 37, 92 }, new byte[] { 251, 229, 177, 201, 15, 218, 38, 175, 252, 105, 156, 155, 239, 223, 250, 118, 62, 40, 7, 199, 31, 61, 66, 228, 193, 108, 105, 123, 115, 12, 187, 164, 104, 63, 119, 204, 183, 225, 109, 55, 155, 66, 241, 44, 131, 201, 145, 219, 43, 195, 165, 115, 115, 239, 176, 251, 129, 10, 117, 228, 58, 86, 72, 144, 147, 246, 212, 69, 190, 8, 196, 38, 214, 70, 20, 185, 125, 147, 42, 82, 73, 217, 109, 33, 139, 121, 224, 29, 127, 248, 121, 248, 190, 77, 43, 209, 173, 13, 222, 89, 218, 119, 54, 118, 37, 171, 144, 153, 183, 129, 190, 114, 53, 22, 150, 62, 88, 119, 34, 123, 182, 232, 110, 1, 101, 31, 0, 192 }, new Guid("256c438e-4ce8-4a9e-af67-7582c3c4bd2f") });
        }
    }
}
