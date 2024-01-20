using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PessoaFisica.Migrations
{
    /// <inheritdoc />
    public partial class GerarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Logradouro1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CEP1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Numero1 = table.Column<int>(type: "int", maxLength: 5, nullable: true),
                    Complemento1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Cidade1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Estado1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Logradouro2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CEP2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Numero2 = table.Column<int>(type: "int", maxLength: 5, nullable: true),
                    Complemento2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Cidade2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Estado2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Nome1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ValorContato1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TipoContato1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ValorContato2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TipoContato2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_UsuarioId",
                table: "Pessoas",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
