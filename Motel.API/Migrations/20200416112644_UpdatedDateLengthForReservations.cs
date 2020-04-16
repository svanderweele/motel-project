using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.API.Migrations
{
    public partial class UpdatedDateLengthForReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Reservations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepartureDate",
                table: "Reservations",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ArrivalDate",
                table: "Reservations",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { new byte[] { 69, 151, 33, 156, 7, 86, 53, 174, 60, 15, 248, 73, 234, 239, 143, 47, 81, 137, 184, 244, 173, 132, 225, 209, 224, 74, 217, 154, 3, 111, 91, 125, 23, 33, 207, 180, 60, 51, 37, 35, 198, 20, 175, 223, 114, 209, 126, 70, 54, 109, 70, 132, 111, 14, 123, 30, 172, 167, 123, 230, 183, 120, 159, 69 }, new byte[] { 177, 98, 220, 125, 139, 59, 181, 250, 190, 138, 245, 83, 92, 204, 133, 140, 206, 61, 88, 29, 228, 170, 191, 210, 198, 142, 61, 255, 220, 213, 182, 239, 128, 234, 96, 89, 238, 37, 220, 126, 68, 239, 203, 255, 249, 50, 246, 213, 49, 243, 108, 115, 133, 36, 84, 98, 8, 208, 62, 173, 122, 6, 174, 80, 255, 83, 237, 92, 59, 96, 57, 165, 26, 58, 182, 170, 206, 91, 90, 91, 246, 112, 96, 249, 242, 17, 178, 13, 4, 143, 143, 141, 87, 137, 41, 51, 17, 255, 236, 244, 199, 46, 247, 249, 207, 6, 38, 95, 135, 159, 112, 64, 177, 210, 1, 168, 58, 158, 129, 228, 14, 124, 174, 209, 142, 72, 16, 187 }, new Guid("c34fc911-0425-4cff-87c6-d92949d9986b") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DepartureDate",
                table: "Reservations",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ArrivalDate",
                table: "Reservations",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<DateTime>(
                name: "Test",
                table: "Reservations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { new byte[] { 224, 57, 42, 133, 5, 40, 21, 218, 100, 53, 167, 213, 251, 103, 208, 251, 138, 59, 34, 231, 231, 255, 180, 170, 226, 112, 244, 237, 20, 132, 213, 35, 82, 55, 219, 66, 26, 180, 95, 206, 224, 38, 210, 65, 67, 101, 244, 217, 97, 156, 200, 153, 16, 113, 176, 3, 27, 246, 233, 94, 122, 137, 217, 101 }, new byte[] { 248, 121, 106, 84, 159, 59, 147, 88, 44, 230, 89, 94, 218, 51, 114, 210, 123, 54, 202, 44, 163, 183, 30, 177, 243, 153, 216, 235, 112, 22, 21, 231, 142, 216, 102, 48, 174, 253, 191, 192, 207, 86, 202, 248, 162, 93, 79, 167, 149, 249, 249, 152, 125, 98, 187, 169, 194, 251, 11, 83, 106, 22, 186, 217, 85, 10, 53, 74, 84, 218, 88, 161, 212, 93, 207, 131, 120, 15, 244, 110, 46, 118, 90, 86, 7, 54, 5, 150, 110, 103, 86, 27, 100, 200, 135, 44, 253, 90, 30, 60, 20, 18, 62, 180, 169, 226, 59, 212, 50, 215, 143, 128, 73, 146, 69, 84, 158, 188, 199, 134, 77, 35, 251, 50, 174, 148, 129, 219 }, new Guid("8b8706e3-02b0-4835-8f28-089566705938") });
        }
    }
}
