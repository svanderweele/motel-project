using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.API.Migrations
{
    public partial class MadeSoftDeletesNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeletedAt", "Ref" },
                values: new object[] { null, new Guid("9a9b8728-9b80-47bb-82c0-2f2fda63956e") });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeletedAt", "Ref" },
                values: new object[] { null, new Guid("d12eb2fd-21da-4cb3-b68b-2bc6353dcbc7") });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeletedAt", "Ref" },
                values: new object[] { null, new Guid("919dff00-955c-4d9d-b860-6b618e4dcf9a") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeletedAt", "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { null, new byte[] { 85, 29, 243, 248, 130, 83, 211, 83, 152, 253, 184, 73, 189, 78, 40, 42, 203, 53, 214, 38, 239, 152, 159, 80, 137, 137, 166, 157, 195, 139, 168, 171, 176, 121, 92, 78, 114, 187, 180, 165, 153, 53, 127, 4, 193, 217, 163, 49, 203, 33, 23, 26, 43, 240, 167, 204, 104, 156, 236, 146, 25, 138, 5, 230 }, new byte[] { 60, 247, 48, 61, 85, 224, 85, 140, 2, 240, 146, 207, 232, 102, 170, 173, 89, 100, 117, 57, 99, 100, 20, 184, 23, 186, 174, 59, 70, 184, 155, 144, 175, 227, 245, 152, 188, 169, 234, 206, 229, 217, 255, 249, 239, 74, 119, 3, 47, 140, 208, 198, 96, 64, 190, 106, 201, 192, 163, 246, 47, 99, 30, 119, 114, 197, 82, 213, 161, 74, 6, 24, 27, 249, 125, 227, 173, 89, 177, 99, 56, 69, 107, 198, 201, 110, 192, 3, 92, 239, 129, 135, 201, 45, 232, 125, 188, 215, 15, 146, 64, 182, 54, 22, 176, 152, 94, 11, 2, 67, 68, 73, 195, 143, 147, 111, 139, 148, 97, 120, 87, 153, 78, 99, 194, 126, 58, 18 }, new Guid("ad3b24fd-a04d-4f94-b17f-5e4b4e2b4bdd") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Reservations",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeletedAt", "Ref" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0d1a70be-6876-4f51-81e6-821d22eae51b") });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeletedAt", "Ref" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("318311d2-0c95-41a7-974f-a96a5d693b96") });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeletedAt", "Ref" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d611c757-06a8-45ce-91c9-e53fa040d938") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeletedAt", "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 84, 109, 18, 92, 168, 169, 46, 47, 128, 56, 38, 220, 71, 42, 193, 42, 144, 5, 229, 23, 194, 171, 82, 203, 200, 6, 82, 63, 135, 161, 144, 13, 2, 13, 58, 163, 110, 247, 40, 2, 180, 218, 132, 106, 191, 226, 134, 206, 36, 73, 222, 207, 114, 128, 113, 72, 75, 249, 93, 130, 60, 246, 91, 225 }, new byte[] { 70, 204, 86, 117, 208, 231, 43, 234, 207, 88, 150, 146, 146, 192, 98, 20, 95, 172, 223, 224, 212, 115, 114, 187, 226, 63, 212, 91, 113, 168, 251, 78, 111, 228, 22, 137, 139, 49, 163, 128, 144, 47, 57, 150, 228, 92, 82, 215, 156, 191, 25, 155, 209, 44, 36, 19, 105, 3, 180, 68, 91, 155, 42, 50, 3, 186, 63, 206, 120, 27, 219, 34, 73, 240, 2, 238, 8, 157, 86, 77, 163, 121, 159, 45, 193, 44, 233, 40, 92, 22, 31, 219, 34, 204, 231, 164, 190, 58, 144, 91, 220, 5, 156, 234, 185, 234, 8, 119, 225, 135, 165, 111, 199, 173, 8, 201, 206, 254, 34, 100, 144, 71, 167, 174, 145, 8, 232, 202 }, new Guid("484b3202-fc51-41a2-b509-ba3f7cbee93c") });
        }
    }
}
