using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Election10.Migrations
{
    public partial class InitialMigrationOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appeals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    VirtualCantonId = table.Column<int>(nullable: false),
                    CitizensId = table.Column<int>(nullable: false),
                    CandidateId = table.Column<int>(nullable: false),
                    VirtualDistrictId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appeals_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appeals_Citizenses_CitizensId",
                        column: x => x.CitizensId,
                        principalTable: "Citizenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appeals_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appeals_VirtualCantons_VirtualCantonId",
                        column: x => x.VirtualCantonId,
                        principalTable: "VirtualCantons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appeals_VirtualDistricts_VirtualDistrictId",
                        column: x => x.VirtualDistrictId,
                        principalTable: "VirtualDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Watchers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    VirtualCantonId = table.Column<int>(nullable: false),
                    CandidateId = table.Column<int>(nullable: false),
                    CitizensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Watchers_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watchers_Citizenses_CitizensId",
                        column: x => x.CitizensId,
                        principalTable: "Citizenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watchers_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watchers_VirtualCantons_VirtualCantonId",
                        column: x => x.VirtualCantonId,
                        principalTable: "VirtualCantons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Complaintses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Type = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    ElectionId = table.Column<int>(nullable: false),
                    VirtualCantonId = table.Column<int>(nullable: false),
                    WatcherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaintses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaintses_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaintses_VirtualCantons_VirtualCantonId",
                        column: x => x.VirtualCantonId,
                        principalTable: "VirtualCantons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaintses_Watchers_WatcherId",
                        column: x => x.WatcherId,
                        principalTable: "Watchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appeals_CandidateId",
                table: "Appeals",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Appeals_CitizensId",
                table: "Appeals",
                column: "CitizensId");

            migrationBuilder.CreateIndex(
                name: "IX_Appeals_ElectionId",
                table: "Appeals",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Appeals_VirtualCantonId",
                table: "Appeals",
                column: "VirtualCantonId");

            migrationBuilder.CreateIndex(
                name: "IX_Appeals_VirtualDistrictId",
                table: "Appeals",
                column: "VirtualDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaintses_ElectionId",
                table: "Complaintses",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaintses_VirtualCantonId",
                table: "Complaintses",
                column: "VirtualCantonId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaintses_WatcherId",
                table: "Complaintses",
                column: "WatcherId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchers_CandidateId",
                table: "Watchers",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchers_CitizensId",
                table: "Watchers",
                column: "CitizensId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchers_ElectionId",
                table: "Watchers",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchers_VirtualCantonId",
                table: "Watchers",
                column: "VirtualCantonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appeals");

            migrationBuilder.DropTable(
                name: "Complaintses");

            migrationBuilder.DropTable(
                name: "Watchers");
        }
    }
}
