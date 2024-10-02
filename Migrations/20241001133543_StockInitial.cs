using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspnetCoreMvcFull.Migrations
{
    /// <inheritdoc />
    public partial class StockInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    companyNamePanels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    panelCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberPanels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pricePanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagePanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyNameInverter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelInverter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inverterCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inverterPhase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    priceInverter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberInverters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batteryNameInverter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batteryModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batteryCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batteryPhase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batteryPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberBatteries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batteryImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockEntries");
        }
    }
}
