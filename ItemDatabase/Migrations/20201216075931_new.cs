using Microsoft.EntityFrameworkCore.Migrations;

namespace ItemDatabase.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    SpritePath = table.Column<string>(nullable: true),
                    AttackDamage = table.Column<float>(nullable: false),
                    AddedProjectiles = table.Column<int>(nullable: false),
                    AttackSpeed = table.Column<float>(nullable: false),
                    ItemHealing = table.Column<float>(nullable: false),
                    MoveSpeed = table.Column<float>(nullable: false),
                    MaxLife = table.Column<int>(nullable: false),
                    unlocked = table.Column<bool>(type: "bool", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemTable");
        }
    }
}
