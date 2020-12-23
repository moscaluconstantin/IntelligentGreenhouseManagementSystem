using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFromsApp1.Database.Migrations
{
    public partial class _1stMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Strategies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrategyName = table.Column<string>(nullable: true),
                    SoilTemperature = table.Column<double>(nullable: false),
                    AirTemperature = table.Column<double>(nullable: false),
                    Humidity = table.Column<double>(nullable: false),
                    SoilMoisture = table.Column<double>(nullable: false),
                    CO2 = table.Column<double>(nullable: false),
                    Ph = table.Column<double>(nullable: false),
                    Illumintation = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strategies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoneName = table.Column<string>(nullable: true),
                    StrategyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zones_Strategies_StrategyId",
                        column: x => x.StrategyId,
                        principalTable: "Strategies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoneId = table.Column<int>(nullable: false),
                    SoilTemperature = table.Column<double>(nullable: false),
                    AirTemperature = table.Column<double>(nullable: false),
                    Humidity = table.Column<double>(nullable: false),
                    SoilMoisture = table.Column<double>(nullable: false),
                    CO2 = table.Column<double>(nullable: false),
                    Ph = table.Column<double>(nullable: false),
                    Illumintation = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataHistories_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataHistories_ZoneId",
                table: "DataHistories",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_StrategyId",
                table: "Zones",
                column: "StrategyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataHistories");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Strategies");
        }
    }
}
