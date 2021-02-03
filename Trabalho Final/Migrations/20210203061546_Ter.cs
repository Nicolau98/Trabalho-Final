using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Final.Migrations
{
    public partial class Ter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartaConducao",
                columns: table => new
                {
                    CartaConducaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartaConducao", x => x.CartaConducaoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartaConducao");
        }
    }
}
