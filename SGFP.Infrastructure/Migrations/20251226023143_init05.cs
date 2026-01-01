using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGFP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB011_CATEGORIA_PRODUTO_COMPRA",
                columns: table => new
                {
                    CATEGORIA_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORIA_PRODUTO_COMPRA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB011_CATEGORIA_PRODUTO_COMPRA", x => x.CATEGORIA_PRODUTO_COMPRA_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB012_UNIDADE_PRODUTO_COMPRA",
                columns: table => new
                {
                    UNIDADE_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UNIDADE_PRODUTO_COMPRA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB012_UNIDADE_PRODUTO_COMPRA", x => x.UNIDADE_PRODUTO_COMPRA_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB013_ITEM_PRODUTO_COMPRA",
                columns: table => new
                {
                    ITEM_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEM_PRODUTO_COMPRA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria_Produto_Compra_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB013_ITEM_PRODUTO_COMPRA", x => x.ITEM_PRODUTO_COMPRA_ID);
                    table.ForeignKey(
                        name: "FK_TB013_ITEM_PRODUTO_COMPRA_TB011_CATEGORIA_PRODUTO_COMPRA_categoria_Produto_Compra_ID",
                        column: x => x.categoria_Produto_Compra_ID,
                        principalTable: "TB011_CATEGORIA_PRODUTO_COMPRA",
                        principalColumn: "CATEGORIA_PRODUTO_COMPRA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB013_ITEM_PRODUTO_COMPRA_categoria_Produto_Compra_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                column: "categoria_Produto_Compra_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB012_UNIDADE_PRODUTO_COMPRA");

            migrationBuilder.DropTable(
                name: "TB013_ITEM_PRODUTO_COMPRA");

            migrationBuilder.DropTable(
                name: "TB011_CATEGORIA_PRODUTO_COMPRA");
        }
    }
}
