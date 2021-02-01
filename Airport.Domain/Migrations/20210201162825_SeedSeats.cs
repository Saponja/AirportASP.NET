using Microsoft.EntityFrameworkCore.Migrations;

namespace Airport.Domain.Migrations
{
    public partial class SeedSeats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "AirplaneId", "Class", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Business", 150.0 },
                    { 2, 1, "Business", 180.0 },
                    { 3, 1, "Economy", 100.0 },
                    { 4, 1, "FirstClass", 220.0 },
                    { 5, 2, "Business", 160.0 },
                    { 6, 2, "Economy", 90.0 },
                    { 7, 2, "Economy", 100.0 },
                    { 8, 3, "FirstClass", 250.0 },
                    { 9, 3, "Business", 190.0 },
                    { 10, 4, "Economy", 80.0 },
                    { 11, 4, "Economy", 110.0 },
                    { 12, 5, "Business", 175.0 },
                    { 13, 5, "Economy", 120.0 },
                    { 14, 6, "FirstClass", 225.0 },
                    { 15, 6, "FirstClass", 240.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 15);
        }
    }
}
