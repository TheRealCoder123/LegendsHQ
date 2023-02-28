using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegendsHQ.Migrations
{
    public partial class initalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "legendClasses",
                columns: table => new
                {
                    class_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    legend_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    class_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    class_icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    class_description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_legendClasses", x => x.class_id);
                });

            migrationBuilder.CreateTable(
                name: "legendFinishers",
                columns: table => new
                {
                    finisher_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    finisher_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_apex_coins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_crafting_materials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_legend_tokens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    finisher_video_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_legendFinishers", x => x.finisher_id);
                });

            migrationBuilder.CreateTable(
                name: "legendVideos",
                columns: table => new
                {
                    video_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    legend_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_legendVideos", x => x.video_id);
                });

            migrationBuilder.CreateTable(
                name: "legends",
                columns: table => new
                {
                    legend_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slogan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saying = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    season_created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    home_planet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tactical_ability_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passive_ability_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ultimate_ability_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    featuring_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_apex_coins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_legend_tokens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_health = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_speed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    legend_difficulty = table.Column<int>(type: "int", nullable: false),
                    legend_classclass_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    video_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_legends", x => x.legend_id);
                    table.ForeignKey(
                        name: "FK_legends_legendClasses_legend_classclass_id",
                        column: x => x.legend_classclass_id,
                        principalTable: "legendClasses",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_legends_legendVideos_video_id",
                        column: x => x.video_id,
                        principalTable: "legendVideos",
                        principalColumn: "video_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "abilitys",
                columns: table => new
                {
                    ability_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    legend_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ability_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ability_icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ability_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cooldown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ability_type = table.Column<int>(type: "int", nullable: false),
                    legend_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abilitys", x => x.ability_id);
                    table.ForeignKey(
                        name: "FK_abilitys_legends_legend_id1",
                        column: x => x.legend_id1,
                        principalTable: "legends",
                        principalColumn: "legend_id");
                });

            migrationBuilder.CreateTable(
                name: "legendImages",
                columns: table => new
                {
                    image_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    legend_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    legend_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_legendImages", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_legendImages_legends_legend_id1",
                        column: x => x.legend_id1,
                        principalTable: "legends",
                        principalColumn: "legend_id");
                });

            migrationBuilder.CreateTable(
                name: "legendSkins",
                columns: table => new
                {
                    skin_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    legend_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cost_crafting_materials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_legend_tokens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_apex_coins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skin_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    legend_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_legendSkins", x => x.skin_id);
                    table.ForeignKey(
                        name: "FK_legendSkins_legends_legend_id1",
                        column: x => x.legend_id1,
                        principalTable: "legends",
                        principalColumn: "legend_id");
                });

            migrationBuilder.CreateTable(
                name: "abilityInteractions",
                columns: table => new
                {
                    interaction_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ability_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    interaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ability_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abilityInteractions", x => x.interaction_id);
                    table.ForeignKey(
                        name: "FK_abilityInteractions_abilitys_ability_id1",
                        column: x => x.ability_id1,
                        principalTable: "abilitys",
                        principalColumn: "ability_id");
                });

            migrationBuilder.CreateTable(
                name: "abilityTips",
                columns: table => new
                {
                    tip_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ability_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ability_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abilityTips", x => x.tip_id);
                    table.ForeignKey(
                        name: "FK_abilityTips_abilitys_ability_id1",
                        column: x => x.ability_id1,
                        principalTable: "abilitys",
                        principalColumn: "ability_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_abilityInteractions_ability_id1",
                table: "abilityInteractions",
                column: "ability_id1");

            migrationBuilder.CreateIndex(
                name: "IX_abilitys_legend_id1",
                table: "abilitys",
                column: "legend_id1");

            migrationBuilder.CreateIndex(
                name: "IX_abilityTips_ability_id1",
                table: "abilityTips",
                column: "ability_id1");

            migrationBuilder.CreateIndex(
                name: "IX_legendImages_legend_id1",
                table: "legendImages",
                column: "legend_id1");

            migrationBuilder.CreateIndex(
                name: "IX_legends_legend_classclass_id",
                table: "legends",
                column: "legend_classclass_id");

            migrationBuilder.CreateIndex(
                name: "IX_legends_video_id",
                table: "legends",
                column: "video_id");

            migrationBuilder.CreateIndex(
                name: "IX_legendSkins_legend_id1",
                table: "legendSkins",
                column: "legend_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abilityInteractions");

            migrationBuilder.DropTable(
                name: "abilityTips");

            migrationBuilder.DropTable(
                name: "legendFinishers");

            migrationBuilder.DropTable(
                name: "legendImages");

            migrationBuilder.DropTable(
                name: "legendSkins");

            migrationBuilder.DropTable(
                name: "abilitys");

            migrationBuilder.DropTable(
                name: "legends");

            migrationBuilder.DropTable(
                name: "legendClasses");

            migrationBuilder.DropTable(
                name: "legendVideos");
        }
    }
}
