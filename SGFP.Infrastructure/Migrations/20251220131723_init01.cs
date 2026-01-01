using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGFP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB001_CATEGORIA",
                columns: table => new
                {
                    CATEGORIA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB001_CATEGORIA", x => x.CATEGORIA_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB002_ITEM_LISTA_COMPRA",
                columns: table => new
                {
                    ITEM_LISTA_COMPRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO_ID = table.Column<int>(type: "int", nullable: false),
                    CATEGORIA_ID = table.Column<int>(type: "int", nullable: false),
                    NOME_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    marca_Produto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VALOR_UNITARIO = table.Column<double>(type: "double precision", nullable: false),
                    QUANTIDADE_PRODUTO = table.Column<int>(type: "int", nullable: false),
                    SUB_TOTAL_PRODUTOS = table.Column<double>(type: "double precision", nullable: false),
                    DATA_COMPRA_PRODUTOS = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB002_ITEM_LISTA_COMPRA", x => x.ITEM_LISTA_COMPRA_ID);
                    table.ForeignKey(
                        name: "FK_TB002_ITEM_LISTA_COMPRA_TB001_CATEGORIA_CATEGORIA_ID",
                        column: x => x.CATEGORIA_ID,
                        principalTable: "TB001_CATEGORIA",
                        principalColumn: "CATEGORIA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB002_ITEM_LISTA_COMPRA_CATEGORIA_ID",
                table: "TB002_ITEM_LISTA_COMPRA",
                column: "CATEGORIA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB002_ITEM_LISTA_COMPRA");

            migrationBuilder.DropTable(
                name: "TB001_CATEGORIA");
        }
    }
}
