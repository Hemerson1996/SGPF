using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGFP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB014_ITEM_COMPRA",
                columns: table => new
                {
                    ITEM_COMPRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO_ID = table.Column<int>(type: "int", nullable: false),
                    CATEGORIA_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false),
                    UNIDADE_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_COMPRA_QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    ITEM_COMPRA_PRECO_UNITARIO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ITEM_COMPRA_TOTAL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ITEM_COMPRA_DATA_COMPRA = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB014_ITEM_COMPRA", x => x.ITEM_COMPRA_ID);
                    table.ForeignKey(
                        name: "FK_TB014_ITEM_COMPRA_TB011_CATEGORIA_PRODUTO_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID",
                        column: x => x.CATEGORIA_PRODUTO_COMPRA_ID,
                        principalTable: "TB011_CATEGORIA_PRODUTO_COMPRA",
                        principalColumn: "CATEGORIA_PRODUTO_COMPRA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB014_ITEM_COMPRA_TB012_UNIDADE_PRODUTO_COMPRA_UNIDADE_PRODUTO_COMPRA_ID",
                        column: x => x.UNIDADE_PRODUTO_COMPRA_ID,
                        principalTable: "TB012_UNIDADE_PRODUTO_COMPRA",
                        principalColumn: "UNIDADE_PRODUTO_COMPRA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB014_ITEM_COMPRA_TB013_ITEM_PRODUTO_COMPRA_ITEM_PRODUTO_COMPRA_ID",
                        column: x => x.ITEM_PRODUTO_COMPRA_ID,
                        principalTable: "TB013_ITEM_PRODUTO_COMPRA",
                        principalColumn: "ITEM_PRODUTO_COMPRA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB014_ITEM_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID",
                table: "TB014_ITEM_COMPRA",
                column: "CATEGORIA_PRODUTO_COMPRA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB014_ITEM_COMPRA_ITEM_PRODUTO_COMPRA_ID",
                table: "TB014_ITEM_COMPRA",
                column: "ITEM_PRODUTO_COMPRA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB014_ITEM_COMPRA_UNIDADE_PRODUTO_COMPRA_ID",
                table: "TB014_ITEM_COMPRA",
                column: "UNIDADE_PRODUTO_COMPRA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB014_ITEM_COMPRA");
        }
    }
}
