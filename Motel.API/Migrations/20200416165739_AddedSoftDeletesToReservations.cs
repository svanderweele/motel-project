using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.API.Migrations
{
    public partial class AddedSoftDeletesToReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Reservations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ref",
                value: new Guid("0d1a70be-6876-4f51-81e6-821d22eae51b"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ref",
                value: new Guid("318311d2-0c95-41a7-974f-a96a5d693b96"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Ref",
                value: new Guid("d611c757-06a8-45ce-91c9-e53fa040d938"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { new byte[] { 84, 109, 18, 92, 168, 169, 46, 47, 128, 56, 38, 220, 71, 42, 193, 42, 144, 5, 229, 23, 194, 171, 82, 203, 200, 6, 82, 63, 135, 161, 144, 13, 2, 13, 58, 163, 110, 247, 40, 2, 180, 218, 132, 106, 191, 226, 134, 206, 36, 73, 222, 207, 114, 128, 113, 72, 75, 249, 93, 130, 60, 246, 91, 225 }, new byte[] { 70, 204, 86, 117, 208, 231, 43, 234, 207, 88, 150, 146, 146, 192, 98, 20, 95, 172, 223, 224, 212, 115, 114, 187, 226, 63, 212, 91, 113, 168, 251, 78, 111, 228, 22, 137, 139, 49, 163, 128, 144, 47, 57, 150, 228, 92, 82, 215, 156, 191, 25, 155, 209, 44, 36, 19, 105, 3, 180, 68, 91, 155, 42, 50, 3, 186, 63, 206, 120, 27, 219, 34, 73, 240, 2, 238, 8, 157, 86, 77, 163, 121, 159, 45, 193, 44, 233, 40, 92, 22, 31, 219, 34, 204, 231, 164, 190, 58, 144, 91, 220, 5, 156, 234, 185, 234, 8, 119, 225, 135, 165, 111, 199, 173, 8, 201, 206, 254, 34, 100, 144, 71, 167, 174, 145, 8, 232, 202 }, new Guid("484b3202-fc51-41a2-b509-ba3f7cbee93c") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Reservations");

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
    }
}
