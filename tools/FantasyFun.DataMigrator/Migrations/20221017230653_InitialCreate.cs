using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyFun.DataMigrator.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    league_id = table.Column<int>(type: "int", nullable: false),
                    season = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stage = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    match_api_id = table.Column<int>(type: "int", nullable: false),
                    home_team_api_id = table.Column<int>(type: "int", nullable: false),
                    away_team_api_id = table.Column<int>(type: "int", nullable: false),
                    home_team_goal = table.Column<int>(type: "int", nullable: false),
                    away_team_goal = table.Column<int>(type: "int", nullable: false),
                    home_player_X1 = table.Column<int>(type: "int", nullable: true),
                    home_player_X2 = table.Column<int>(type: "int", nullable: true),
                    home_player_X3 = table.Column<int>(type: "int", nullable: true),
                    home_player_X4 = table.Column<int>(type: "int", nullable: true),
                    home_player_X5 = table.Column<int>(type: "int", nullable: true),
                    home_player_X6 = table.Column<int>(type: "int", nullable: true),
                    home_player_X7 = table.Column<int>(type: "int", nullable: true),
                    home_player_X8 = table.Column<int>(type: "int", nullable: true),
                    home_player_X9 = table.Column<int>(type: "int", nullable: true),
                    home_player_X10 = table.Column<int>(type: "int", nullable: true),
                    home_player_X11 = table.Column<int>(type: "int", nullable: true),
                    away_player_X1 = table.Column<int>(type: "int", nullable: true),
                    away_player_X2 = table.Column<int>(type: "int", nullable: true),
                    away_player_X3 = table.Column<int>(type: "int", nullable: true),
                    away_player_X4 = table.Column<int>(type: "int", nullable: true),
                    away_player_X5 = table.Column<int>(type: "int", nullable: true),
                    away_player_X6 = table.Column<int>(type: "int", nullable: true),
                    away_player_X7 = table.Column<int>(type: "int", nullable: true),
                    away_player_X8 = table.Column<int>(type: "int", nullable: true),
                    away_player_X9 = table.Column<int>(type: "int", nullable: true),
                    away_player_X10 = table.Column<int>(type: "int", nullable: true),
                    away_player_X11 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y1 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y2 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y3 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y4 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y5 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y6 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y7 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y8 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y9 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y10 = table.Column<int>(type: "int", nullable: true),
                    home_player_Y11 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y1 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y2 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y3 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y4 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y5 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y6 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y7 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y8 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y9 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y10 = table.Column<int>(type: "int", nullable: true),
                    away_player_Y11 = table.Column<int>(type: "int", nullable: true),
                    home_player_1 = table.Column<int>(type: "int", nullable: true),
                    home_player_2 = table.Column<int>(type: "int", nullable: true),
                    home_player_3 = table.Column<int>(type: "int", nullable: true),
                    home_player_4 = table.Column<int>(type: "int", nullable: true),
                    home_player_5 = table.Column<int>(type: "int", nullable: true),
                    home_player_6 = table.Column<int>(type: "int", nullable: true),
                    home_player_7 = table.Column<int>(type: "int", nullable: true),
                    home_player_8 = table.Column<int>(type: "int", nullable: true),
                    home_player_9 = table.Column<int>(type: "int", nullable: true),
                    home_player_10 = table.Column<int>(type: "int", nullable: true),
                    home_player_11 = table.Column<int>(type: "int", nullable: true),
                    away_player_1 = table.Column<int>(type: "int", nullable: true),
                    away_player_2 = table.Column<int>(type: "int", nullable: true),
                    away_player_3 = table.Column<int>(type: "int", nullable: true),
                    away_player_4 = table.Column<int>(type: "int", nullable: true),
                    away_player_5 = table.Column<int>(type: "int", nullable: true),
                    away_player_6 = table.Column<int>(type: "int", nullable: true),
                    away_player_7 = table.Column<int>(type: "int", nullable: true),
                    away_player_8 = table.Column<int>(type: "int", nullable: true),
                    away_player_9 = table.Column<int>(type: "int", nullable: true),
                    away_player_10 = table.Column<int>(type: "int", nullable: true),
                    away_player_11 = table.Column<int>(type: "int", nullable: true),
                    goal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    player_api_id = table.Column<int>(type: "int", nullable: false),
                    player_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    player_fifa_api_id = table.Column<int>(type: "int", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    id = table.Column<long>(type: "bigint", nullable: false),
                    team_fifa_api_id = table.Column<long>(type: "bigint", nullable: true),
                    team_api_id = table.Column<long>(type: "bigint", nullable: false),
                    team_long_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    team_short_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    country_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    id = table.Column<int>(type: "int", nullable: false),
                    player_fifa_api_id = table.Column<int>(type: "int", nullable: false),
                    player_api_id = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    overall_rating = table.Column<long>(type: "bigint", nullable: true)
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
                name: "Match");

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
