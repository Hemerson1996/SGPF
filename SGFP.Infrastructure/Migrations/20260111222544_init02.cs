using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGFP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB007_RECEITA_TB003_CATEGORIA_RECEITA_TB003_Categoria_ReceitacategoriaReceita_Id",
                table: "TB007_RECEITA");

            migrationBuilder.DropIndex(
                name: "IX_TB007_RECEITA_TB003_Categoria_ReceitacategoriaReceita_Id",
                table: "TB007_RECEITA");

            migrationBuilder.DropColumn(
                name: "TB003_Categoria_ReceitacategoriaReceita_Id",
                table: "TB007_RECEITA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TB003_Categoria_ReceitacategoriaReceita_Id",
                table: "TB007_RECEITA",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB007_RECEITA_TB003_Categoria_ReceitacategoriaReceita_Id",
                table: "TB007_RECEITA",
                column: "TB003_Categoria_ReceitacategoriaReceita_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB007_RECEITA_TB003_CATEGORIA_RECEITA_TB003_Categoria_ReceitacategoriaReceita_Id",
                table: "TB007_RECEITA",
                column: "TB003_Categoria_ReceitacategoriaReceita_Id",
                principalTable: "TB003_CATEGORIA_RECEITA",
                principalColumn: "CATEGORIA_RECEITA_ID");
        }
    }
}
