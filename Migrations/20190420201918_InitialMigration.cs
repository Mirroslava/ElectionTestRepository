using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Election10.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    PIN = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    StartElection = table.Column<DateTime>(nullable: false),
                    EndElection = table.Column<DateTime>(nullable: false),
                    ChairmanCC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elections", x => x.Id);
                });

           

            migrationBuilder.CreateTable(
                name: "VirtualCantons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Centre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualCantons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirtualDistricts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    VirtualCantonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualDistricts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NumberInTheList = table.Column<int>(nullable: false),
                    ElectionId = table.Column<int>(nullable: false),
                    CitizensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_Citizenses_CitizensId",
                        column: x => x.CitizensId,
                        principalTable: "Citizenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidates_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChairmanCCs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    VirtualCantonId = table.Column<int>(nullable: false),
                    CitizensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChairmanCCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChairmanCCs_Citizenses_CitizensId",
                        column: x => x.CitizensId,
                        principalTable: "Citizenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChairmanCCs_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChairmanCCs_VirtualCantons_VirtualCantonId",
                        column: x => x.VirtualCantonId,
                        principalTable: "VirtualCantons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharmanDCs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    VirtualCantonId = table.Column<int>(nullable: false),
                    CitizensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharmanDCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharmanDCs_Citizenses_CitizensId",
                        column: x => x.CitizensId,
                        principalTable: "Citizenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharmanDCs_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharmanDCs_VirtualCantons_VirtualCantonId",
                        column: x => x.VirtualCantonId,
                        principalTable: "VirtualCantons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    VirtualCantonId = table.Column<int>(nullable: false),
                    CitizensId = table.Column<int>(nullable: false),
                    CandidatId = table.Column<int>(nullable: false),
                    CandidateId = table.Column<int>(nullable: true),
                    VirtualDistrictId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voices_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voices_Citizenses_CitizensId",
                        column: x => x.CitizensId,
                        principalTable: "Citizenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voices_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voices_VirtualCantons_VirtualCantonId",
                        column: x => x.VirtualCantonId,
                        principalTable: "VirtualCantons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voices_VirtualDistricts_VirtualDistrictId",
                        column: x => x.VirtualDistrictId,
                        principalTable: "VirtualDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_CitizensId",
                table: "Candidates",
                column: "CitizensId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_ElectionId",
                table: "Candidates",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanCCs_CitizensId",
                table: "ChairmanCCs",
                column: "CitizensId");

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanCCs_ElectionId",
                table: "ChairmanCCs",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanCCs_VirtualCantonId",
                table: "ChairmanCCs",
                column: "VirtualCantonId");

            migrationBuilder.CreateIndex(
                name: "IX_CharmanDCs_CitizensId",
                table: "CharmanDCs",
                column: "CitizensId");

            migrationBuilder.CreateIndex(
                name: "IX_CharmanDCs_ElectionId",
                table: "CharmanDCs",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CharmanDCs_VirtualCantonId",
                table: "CharmanDCs",
                column: "VirtualCantonId");

            migrationBuilder.CreateIndex(
                name: "IX_Voices_CandidateId",
                table: "Voices",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Voices_CitizensId",
                table: "Voices",
                column: "CitizensId");

            migrationBuilder.CreateIndex(
                name: "IX_Voices_ElectionId",
                table: "Voices",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Voices_VirtualCantonId",
                table: "Voices",
                column: "VirtualCantonId");

            migrationBuilder.CreateIndex(
                name: "IX_Voices_VirtualDistrictId",
                table: "Voices",
                column: "VirtualDistrictId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChairmanCCs");

            migrationBuilder.DropTable(
                name: "CharmanDCs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Voices");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "VirtualCantons");

            migrationBuilder.DropTable(
                name: "VirtualDistricts");

            migrationBuilder.DropTable(
                name: "Citizenses");

            migrationBuilder.DropTable(
                name: "Elections");
        }
    }
}
