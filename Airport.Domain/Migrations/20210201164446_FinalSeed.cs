using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Airport.Domain.Migrations
{
    public partial class FinalSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirplaneId", "Destination", "FlightDuration" },
                values: new object[,]
                {
                    { 1, 1, "Mexico City", 17.0 },
                    { 2, 1, "New York", 21.0 },
                    { 3, 2, "Mexico City", 14.0 },
                    { 4, 3, "Madrid", 5.0 },
                    { 5, 4, "Moscow", 6.0 },
                    { 6, 5, "London", 8.0 },
                    { 7, 5, "Melbourne", 25.0 }
                });

            migrationBuilder.InsertData(
                table: "Passangers",
                columns: new[] { "PassangerId", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 21, "Jovan", "Saponjic" },
                    { 2, 30, "Pera", "Peric" },
                    { 3, 45, "Zika", "Zikic" },
                    { 4, 17, "Milan", "Jovanovic" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                values: new object[,]
                {
                    { new DateTime(2021, 2, 1, 17, 44, 44, 911, DateTimeKind.Local).AddTicks(5052), 1, 2 },
                    { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3316), 1, 14 },
                    { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3430), 2, 4 },
                    { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3447), 3, 11 },
                    { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3455), 4, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 17, 44, 44, 911, DateTimeKind.Local).AddTicks(5052), 1, 2 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3430), 2, 4 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3455), 4, 6 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3447), 3, 11 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 17, 44, 44, 919, DateTimeKind.Local).AddTicks(3316), 1, 14 });

            migrationBuilder.DeleteData(
                table: "Passangers",
                keyColumn: "PassangerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passangers",
                keyColumn: "PassangerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passangers",
                keyColumn: "PassangerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Passangers",
                keyColumn: "PassangerId",
                keyValue: 4);
        }
    }
}
