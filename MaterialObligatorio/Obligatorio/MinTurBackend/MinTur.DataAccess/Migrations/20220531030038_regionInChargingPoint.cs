using Microsoft.EntityFrameworkCore.Migrations;

namespace MinTur.DataAccess.Migrations
{
    public partial class regionInChargingPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChargingPoints_TouristPoints_TouristPointId",
                table: "ChargingPoints");

            migrationBuilder.DropIndex(
                name: "IX_ChargingPoints_TouristPointId",
                table: "ChargingPoints");

            migrationBuilder.DropColumn(
                name: "TouristPointId",
                table: "ChargingPoints");

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "ChargingPoints",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChargingPoints_RegionId",
                table: "ChargingPoints",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChargingPoints_Regions_RegionId",
                table: "ChargingPoints",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChargingPoints_Regions_RegionId",
                table: "ChargingPoints");

            migrationBuilder.DropIndex(
                name: "IX_ChargingPoints_RegionId",
                table: "ChargingPoints");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "ChargingPoints");

            migrationBuilder.AddColumn<int>(
                name: "TouristPointId",
                table: "ChargingPoints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChargingPoints_TouristPointId",
                table: "ChargingPoints",
                column: "TouristPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChargingPoints_TouristPoints_TouristPointId",
                table: "ChargingPoints",
                column: "TouristPointId",
                principalTable: "TouristPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
