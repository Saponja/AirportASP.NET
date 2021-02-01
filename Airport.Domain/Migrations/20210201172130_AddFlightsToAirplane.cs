using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Airport.Domain.Migrations
{
    public partial class AddFlightsToAirplane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                values: new object[,]
                {
                    { new DateTime(2021, 2, 1, 18, 21, 29, 9, DateTimeKind.Local).AddTicks(2187), 1, 2 },
                    { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6173), 1, 14 },
                    { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6257), 2, 4 },
                    { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6267), 3, 11 },
                    { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6272), 4, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 18, 21, 29, 9, DateTimeKind.Local).AddTicks(2187), 1, 2 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6257), 2, 4 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6272), 4, 6 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6267), 3, 11 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumns: new[] { "DateOfReservation", "PassangerId", "SeatId" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6173), 1, 14 });

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
        }
    }
}
