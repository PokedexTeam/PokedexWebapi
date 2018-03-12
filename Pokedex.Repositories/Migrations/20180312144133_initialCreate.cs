using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pokedex.Repositories.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseAttack = table.Column<int>(type: "int", nullable: false),
                    BaseDefense = table.Column<int>(type: "int", nullable: false),
                    BaseHP = table.Column<int>(type: "int", nullable: false),
                    BaseSpAtk = table.Column<int>(type: "int", nullable: false),
                    BaseSpDef = table.Column<int>(type: "int", nullable: false),
                    BaseSpeed = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonToPokemonSkill",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    PokemonSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonToPokemonSkill", x => new { x.PokemonId, x.PokemonSkillId });
                    table.ForeignKey(
                        name: "FK_PokemonToPokemonSkill_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonToPokemonSkill_PokemonSkills_PokemonSkillId",
                        column: x => x.PokemonSkillId,
                        principalTable: "PokemonSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonToPokemonType",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    PokemonTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonToPokemonType", x => new { x.PokemonId, x.PokemonTypeId });
                    table.ForeignKey(
                        name: "FK_PokemonToPokemonType_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonToPokemonType_PokemonTypes_PokemonTypeId",
                        column: x => x.PokemonTypeId,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonToPokemonSkill_PokemonSkillId",
                table: "PokemonToPokemonSkill",
                column: "PokemonSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonToPokemonType_PokemonTypeId",
                table: "PokemonToPokemonType",
                column: "PokemonTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonToPokemonSkill");

            migrationBuilder.DropTable(
                name: "PokemonToPokemonType");

            migrationBuilder.DropTable(
                name: "PokemonSkills");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "PokemonTypes");
        }
    }
}
