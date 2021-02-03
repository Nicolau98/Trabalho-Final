using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Final.Migrations
{
    public partial class Quarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educacao",
                columns: table => new
                {
                    EducacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Local = table.Column<string>(maxLength: 115, nullable: true),
                    Descricao = table.Column<string>(nullable: false),
                    Data_Inicio = table.Column<string>(maxLength: 10, nullable: false),
                    Data_Fim = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educacao", x => x.EducacaoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educacao");
        }
    }
}
