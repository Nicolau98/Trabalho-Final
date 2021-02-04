using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Final.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apresentacao",
                columns: table => new
                {
                    ApresentacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Nascimento = table.Column<string>(maxLength: 10, nullable: true),
                    Morada = table.Column<string>(maxLength: 115, nullable: true),
                    Texto = table.Column<string>(nullable: false),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apresentacao", x => x.ApresentacaoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apresentacao");
        }
    }
}
