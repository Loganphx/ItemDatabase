using Microsoft.EntityFrameworkCore.Migrations;

namespace ItemDatabase.Migrations
{
    public partial class update0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AttackDamage",
                table: "ItemTable",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttackDamage",
                table: "ItemTable");
        }
    }
}
