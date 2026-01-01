using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGFP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class INIT08 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB013_ITEM_PRODUTO_COMPRA_TB011_CATEGORIA_PRODUTO_COMPRA_categoria_Produto_Compra_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA");

            migrationBuilder.RenameColumn(
                name: "categoria_Produto_Compra_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                newName: "CATEGORIA_PRODUTO_COMPRA_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB013_ITEM_PRODUTO_COMPRA_categoria_Produto_Compra_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                newName: "IX_TB013_ITEM_PRODUTO_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB013_ITEM_PRODUTO_COMPRA_TB011_CATEGORIA_PRODUTO_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                column: "CATEGORIA_PRODUTO_COMPRA_ID",
                principalTable: "TB011_CATEGORIA_PRODUTO_COMPRA",
                principalColumn: "CATEGORIA_PRODUTO_COMPRA_ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB013_ITEM_PRODUTO_COMPRA_TB011_CATEGORIA_PRODUTO_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA");

            migrationBuilder.RenameColumn(
                name: "CATEGORIA_PRODUTO_COMPRA_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                newName: "categoria_Produto_Compra_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB013_ITEM_PRODUTO_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                newName: "IX_TB013_ITEM_PRODUTO_COMPRA_categoria_Produto_Compra_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB013_ITEM_PRODUTO_COMPRA_TB011_CATEGORIA_PRODUTO_COMPRA_categoria_Produto_Compra_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                column: "categoria_Produto_Compra_ID",
                principalTable: "TB011_CATEGORIA_PRODUTO_COMPRA",
                principalColumn: "CATEGORIA_PRODUTO_COMPRA_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
