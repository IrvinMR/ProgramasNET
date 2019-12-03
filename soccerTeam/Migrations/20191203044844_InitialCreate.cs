using Microsoft.EntityFrameworkCore.Migrations;

namespace soccerTeam.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompetitionID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompetitionName = table.Column<string>(maxLength: 80, nullable: false),
                    CompetitionsCompetitionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionID);
                    table.ForeignKey(
                        name: "FK_Competitions_Competitions_CompetitionsCompetitionID",
                        column: x => x.CompetitionsCompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PositionDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    FixtureID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FixtureDate = table.Column<string>(nullable: true),
                    FixtureTime = table.Column<string>(nullable: true),
                    HomeTeamID = table.Column<int>(nullable: false),
                    AwayTeamID = table.Column<int>(nullable: false),
                    CompetitionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.FixtureID);
                    table.ForeignKey(
                        name: "FK_Fixtures_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamID = table.Column<int>(nullable: false),
                    PlayerName = table.Column<string>(maxLength: 80, nullable: false),
                    PlayerSquadNumber = table.Column<int>(nullable: false),
                    PositionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                    table.ForeignKey(
                        name: "FK_Players_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerFixtures",
                columns: table => new
                {
                    FixtureID = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    GoalsScored = table.Column<int>(nullable: false),
                    FixtureID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerFixtures", x => new { x.FixtureID, x.PlayerID });
                    table.UniqueConstraint("AK_PlayerFixtures_FixtureID", x => x.FixtureID);
                    table.ForeignKey(
                        name: "FK_PlayerFixtures_Fixtures_FixtureID1",
                        column: x => x.FixtureID1,
                        principalTable: "Fixtures",
                        principalColumn: "FixtureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerFixtures_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_CompetitionsCompetitionID",
                table: "Competitions",
                column: "CompetitionsCompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_CompetitionID",
                table: "Fixtures",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerFixtures_FixtureID1",
                table: "PlayerFixtures",
                column: "FixtureID1");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerFixtures_PlayerID",
                table: "PlayerFixtures",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PositionID",
                table: "Players",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamID",
                table: "Players",
                column: "TeamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerFixtures");

            migrationBuilder.DropTable(
                name: "Fixtures");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
