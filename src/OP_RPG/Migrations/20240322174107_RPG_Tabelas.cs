using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OP_RPG.Migrations
{
    /// <inheritdoc />
    public partial class RPG_Tabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Classe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClasseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Classe);
                });

            migrationBuilder.CreateTable(
                name: "Origens",
                columns: table => new
                {
                    Origem = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OrigemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Pericia_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pericia_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poder_Origem = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Descricao_Poder = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origens", x => x.Origem);
                });

            migrationBuilder.CreateTable(
                name: "Trilhas",
                columns: table => new
                {
                    Trilha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrilhaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Classe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trilhas", x => x.Trilha);
                    table.ForeignKey(
                        name: "FK_Trilhas_Classes_Classe",
                        column: x => x.Classe,
                        principalTable: "Classes",
                        principalColumn: "Classe");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trilhas_Classe",
                table: "Trilhas",
                column: "Classe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Origens");

            migrationBuilder.DropTable(
                name: "Trilhas");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
