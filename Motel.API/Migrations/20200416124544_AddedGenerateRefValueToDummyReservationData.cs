using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.API.Migrations
{
    public partial class AddedGenerateRefValueToDummyReservationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ref",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ref",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Ref",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { new byte[] { 102, 139, 229, 44, 118, 86, 172, 230, 254, 106, 232, 97, 219, 76, 93, 43, 239, 41, 212, 120, 188, 213, 195, 83, 250, 237, 142, 51, 1, 162, 162, 230, 42, 223, 141, 97, 124, 177, 53, 111, 27, 138, 209, 34, 214, 224, 153, 9, 47, 110, 84, 108, 66, 6, 91, 174, 237, 152, 81, 237, 187, 55, 61, 199 }, new byte[] { 179, 121, 193, 212, 64, 99, 0, 49, 69, 175, 23, 216, 164, 75, 155, 75, 96, 179, 104, 232, 91, 40, 213, 43, 92, 218, 50, 153, 40, 109, 223, 153, 102, 138, 210, 194, 184, 22, 147, 192, 34, 252, 56, 201, 236, 16, 146, 27, 57, 117, 233, 90, 19, 229, 27, 180, 102, 18, 91, 42, 239, 238, 156, 107, 153, 46, 23, 104, 252, 236, 24, 212, 83, 108, 205, 182, 94, 129, 34, 155, 56, 148, 222, 210, 139, 190, 216, 52, 192, 167, 38, 191, 95, 102, 176, 115, 99, 85, 221, 108, 174, 76, 202, 71, 170, 217, 94, 36, 168, 89, 248, 39, 172, 104, 137, 220, 183, 40, 75, 89, 36, 40, 162, 141, 219, 108, 204, 48 }, new Guid("e6e44ff9-19aa-47be-9e4f-271e174b62e3") });
        }
    }
}
