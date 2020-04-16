using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.API.Migrations
{
    public partial class UpdatedDateLengthForReservationsTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomLayouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomLayouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    Ref = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoomLayoutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomLayouts_RoomLayoutId",
                        column: x => x.RoomLayoutId,
                        principalTable: "RoomLayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    Test = table.Column<DateTime>(nullable: false),
                    NumberOfAdults = table.Column<int>(nullable: false),
                    NumberOfChildren = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RoomLayouts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Single" });

            migrationBuilder.InsertData(
                table: "RoomLayouts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Double" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Ref" },
                values: new object[] { 1, "simon@example.com", "Simon van der Weele", new byte[] { 224, 57, 42, 133, 5, 40, 21, 218, 100, 53, 167, 213, 251, 103, 208, 251, 138, 59, 34, 231, 231, 255, 180, 170, 226, 112, 244, 237, 20, 132, 213, 35, 82, 55, 219, 66, 26, 180, 95, 206, 224, 38, 210, 65, 67, 101, 244, 217, 97, 156, 200, 153, 16, 113, 176, 3, 27, 246, 233, 94, 122, 137, 217, 101 }, new byte[] { 248, 121, 106, 84, 159, 59, 147, 88, 44, 230, 89, 94, 218, 51, 114, 210, 123, 54, 202, 44, 163, 183, 30, 177, 243, 153, 216, 235, 112, 22, 21, 231, 142, 216, 102, 48, 174, 253, 191, 192, 207, 86, 202, 248, 162, 93, 79, 167, 149, 249, 249, 152, 125, 98, 187, 169, 194, 251, 11, 83, 106, 22, 186, 217, 85, 10, 53, 74, 84, 218, 88, 161, 212, 93, 207, 131, 120, 15, 244, 110, 46, 118, 90, 86, 7, 54, 5, 150, 110, 103, 86, 27, 100, 200, 135, 44, 253, 90, 30, 60, 20, 18, 62, 180, 169, 226, 59, 212, 50, 215, 143, 128, 73, 146, 69, 84, 158, 188, 199, 134, 77, 35, 251, 50, 174, 148, 129, 219 }, new Guid("8b8706e3-02b0-4835-8f28-089566705938") });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ArrivalDate", "DepartureDate", "NumberOfAdults", "NumberOfChildren", "Test", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "RoomLayoutId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomLayoutId",
                table: "Rooms",
                column: "RoomLayoutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "RoomLayouts");
        }
    }
}
