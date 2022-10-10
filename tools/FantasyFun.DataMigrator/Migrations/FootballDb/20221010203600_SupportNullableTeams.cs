using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyFun.DataMigrator.Migrations.FootballDb
{
    public partial class SupportNullableTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    player_api_id = table.Column<int>(type: "INTEGER", nullable: false),
                    player_name = table.Column<string>(type: "TEXT", nullable: false),
                    player_fifa_api_id = table.Column<int>(type: "INTEGER", nullable: false),
                    birthday = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.id);
                    table.UniqueConstraint("AK_Player_player_api_id", x => x.player_api_id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false),
                    team_fifa_api_id = table.Column<long>(type: "INTEGER", nullable: true),
                    team_api_id = table.Column<long>(type: "INTEGER", nullable: false),
                    team_long_name = table.Column<string>(type: "TEXT", nullable: false),
                    team_short_name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false),
                    country_id = table.Column<long>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.id);
                    table.ForeignKey(
                        name: "FK_League_Country_country_id",
                        column: x => x.country_id,
                        principalTable: "Country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player_Attributes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    player_fifa_api_id = table.Column<int>(type: "INTEGER", nullable: false),
                    player_api_id = table.Column<int>(type: "INTEGER", nullable: false),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    overall_rating = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player_Attributes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Player_Attributes_Player_player_api_id",
                        column: x => x.player_api_id,
                        principalTable: "Player",
                        principalColumn: "player_api_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_League_country_id",
                table: "League",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Attributes_player_api_id",
                table: "Player_Attributes",
                column: "player_api_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.DropTable(
                name: "Player_Attributes");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
