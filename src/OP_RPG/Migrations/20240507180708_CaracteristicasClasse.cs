using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OP_RPG.Migrations
{
    /// <inheritdoc />
    public partial class CaracteristicasClasse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PericiasTreinadas",
                table: "Classes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proficiencias",
                table: "Classes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PtEsforcoInicial",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PtEsforcoNex",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PtVidaInicial",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PtVidaNex",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SanidadeInicial",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SanidadeNex",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PericiasTreinadas",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Proficiencias",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "PtEsforcoInicial",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "PtEsforcoNex",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "PtVidaInicial",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "PtVidaNex",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SanidadeInicial",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SanidadeNex",
                table: "Classes");
        }
    }
}
