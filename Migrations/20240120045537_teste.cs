using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PessoaFisica.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Usuarios_Id",
                table: "Pessoas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pessoas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_UsuarioId",
                table: "Pessoas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Usuarios_UsuarioId",
                table: "Pessoas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Usuarios_UsuarioId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_UsuarioId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pessoas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pessoas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Usuarios_Id",
                table: "Pessoas",
                column: "Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
