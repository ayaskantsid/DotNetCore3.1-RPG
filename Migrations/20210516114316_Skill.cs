using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCore_RPG.Migrations
{
    public partial class Skill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Damage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "characterSkills",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    CharacterSkillCharacterId = table.Column<int>(type: "int", nullable: true),
                    CharacterSkillSkillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characterSkills", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_characterSkills_characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characterSkills_characterSkills_CharacterSkillCharacterId_CharacterSkillSkillId",
                        columns: x => new { x.CharacterSkillCharacterId, x.CharacterSkillSkillId },
                        principalTable: "characterSkills",
                        principalColumns: new[] { "CharacterId", "SkillId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_characterSkills_skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_characterSkills_CharacterSkillCharacterId_CharacterSkillSkillId",
                table: "characterSkills",
                columns: new[] { "CharacterSkillCharacterId", "CharacterSkillSkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_characterSkills_SkillId",
                table: "characterSkills",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "characterSkills");

            migrationBuilder.DropTable(
                name: "skills");
        }
    }
}
