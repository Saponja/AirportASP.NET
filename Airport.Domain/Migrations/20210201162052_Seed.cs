using Microsoft.EntityFrameworkCore.Migrations;

namespace Airport.Domain.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "Company", "Model", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Model1", "Airplane1" },
                    { 2, 5, "Model2", "Airplane2" },
                    { 3, 1, "Model1", "Airplane3" },
                    { 4, 2, "Model3", "Airplane4" },
                    { 5, 1, "Model2", "Airplane5" },
                    { 6, 3, "Model6", "Airplane6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 6);
        }
    }
}
