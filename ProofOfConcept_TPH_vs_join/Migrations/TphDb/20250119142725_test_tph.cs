using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProofOfConcept_TPH_vs_join.Migrations.TphDb
{
    /// <inheritdoc />
    public partial class test_tph : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tph");

            migrationBuilder.CreateTable(
                name: "Entities",
                schema: "tph",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    F12 = table.Column<int>(type: "integer", nullable: true),
                    F13 = table.Column<int>(type: "integer", nullable: true),
                    F14 = table.Column<int>(type: "integer", nullable: true),
                    F15 = table.Column<int>(type: "integer", nullable: true),
                    F16 = table.Column<int>(type: "integer", nullable: true),
                    F22 = table.Column<int>(type: "integer", nullable: true),
                    F23 = table.Column<int>(type: "integer", nullable: true),
                    F24 = table.Column<int>(type: "integer", nullable: true),
                    F25 = table.Column<int>(type: "integer", nullable: true),
                    F26 = table.Column<int>(type: "integer", nullable: true),
                    F32 = table.Column<int>(type: "integer", nullable: true),
                    F33 = table.Column<int>(type: "integer", nullable: true),
                    F34 = table.Column<int>(type: "integer", nullable: true),
                    F35 = table.Column<int>(type: "integer", nullable: true),
                    F36 = table.Column<int>(type: "integer", nullable: true),
                    F42 = table.Column<int>(type: "integer", nullable: true),
                    F43 = table.Column<int>(type: "integer", nullable: true),
                    F44 = table.Column<int>(type: "integer", nullable: true),
                    F45 = table.Column<int>(type: "integer", nullable: true),
                    F46 = table.Column<int>(type: "integer", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entities",
                schema: "tph");
        }
    }
}
