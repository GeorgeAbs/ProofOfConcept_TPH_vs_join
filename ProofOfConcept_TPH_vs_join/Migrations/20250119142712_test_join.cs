using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProofOfConcept_TPH_vs_join.Migrations
{
    /// <inheritdoc />
    public partial class test_join : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "queries_2");

            migrationBuilder.CreateTable(
                name: "EntityTypes",
                schema: "queries_2",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities21",
                schema: "queries_2",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F12 = table.Column<int>(type: "integer", nullable: false),
                    F13 = table.Column<int>(type: "integer", nullable: false),
                    F14 = table.Column<int>(type: "integer", nullable: false),
                    F15 = table.Column<int>(type: "integer", nullable: false),
                    F16 = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EntityTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities21", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities21_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalSchema: "queries_2",
                        principalTable: "EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entities22",
                schema: "queries_2",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F22 = table.Column<int>(type: "integer", nullable: false),
                    F23 = table.Column<int>(type: "integer", nullable: false),
                    F24 = table.Column<int>(type: "integer", nullable: false),
                    F25 = table.Column<int>(type: "integer", nullable: false),
                    F26 = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EntityTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities22", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities22_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalSchema: "queries_2",
                        principalTable: "EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entities23",
                schema: "queries_2",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F32 = table.Column<int>(type: "integer", nullable: false),
                    F33 = table.Column<int>(type: "integer", nullable: false),
                    F34 = table.Column<int>(type: "integer", nullable: false),
                    F35 = table.Column<int>(type: "integer", nullable: false),
                    F36 = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EntityTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities23", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities23_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalSchema: "queries_2",
                        principalTable: "EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entities24",
                schema: "queries_2",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F42 = table.Column<int>(type: "integer", nullable: false),
                    F43 = table.Column<int>(type: "integer", nullable: false),
                    F44 = table.Column<int>(type: "integer", nullable: false),
                    F45 = table.Column<int>(type: "integer", nullable: false),
                    F46 = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EntityTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities24", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities24_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalSchema: "queries_2",
                        principalTable: "EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entities21_EntityTypeId",
                schema: "queries_2",
                table: "Entities21",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities22_EntityTypeId",
                schema: "queries_2",
                table: "Entities22",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities23_EntityTypeId",
                schema: "queries_2",
                table: "Entities23",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities24_EntityTypeId",
                schema: "queries_2",
                table: "Entities24",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_Name",
                schema: "queries_2",
                table: "EntityTypes",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entities21",
                schema: "queries_2");

            migrationBuilder.DropTable(
                name: "Entities22",
                schema: "queries_2");

            migrationBuilder.DropTable(
                name: "Entities23",
                schema: "queries_2");

            migrationBuilder.DropTable(
                name: "Entities24",
                schema: "queries_2");

            migrationBuilder.DropTable(
                name: "EntityTypes",
                schema: "queries_2");
        }
    }
}
