using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OP_RPG.Migrations
{
    /// <inheritdoc />
    public partial class HabilidadeClasse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HabilidadeClasse",
                table: "Classes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HabilidadeClasse",
                table: "Classes");
        }
    }
}
