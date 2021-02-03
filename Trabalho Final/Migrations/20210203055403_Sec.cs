using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Final.Migrations
{
    public partial class Sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lingua",
                columns: table => new
                {
                    LinguaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Coral = table.Column<string>(maxLength: 2, nullable: false),
                    Leitura = table.Column<string>(maxLength: 2, nullable: false),
                    Poral = table.Column<string>(maxLength: 2, nullable: false),
                    Ioral = table.Column<string>(maxLength: 2, nullable: false),
                    Escrita = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lingua", x => x.LinguaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lingua");
        }
    }
}
