using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplyLogbook.Migrations
{
    /// <inheritdoc />
    public partial class updatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdometerReadingAtArrival",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OdometerReadingAtDeparture",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsLoggedIn",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdometerReadingAtArrival",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "OdometerReadingAtDeparture",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "IsLoggedIn",
                table: "AspNetUsers");
        }
    }
}
