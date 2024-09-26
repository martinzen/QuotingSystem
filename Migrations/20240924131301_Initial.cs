using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspnetCoreMvcFull.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuoteEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameLast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    installationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABNnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    electricityRetailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    electricityDis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    propertyPhase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    preapprovalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    storyHouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roofType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    switchBoardUpgrade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuoteEntries");
        }
    }
}
