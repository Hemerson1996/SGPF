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
                name: "TB003_CATEGORIA_RECEITA",
                columns: table => new
                {
                    CATEGORIA_RECEITA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORIA_RECEITA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB003_CATEGORIA_RECEITA", x => x.CATEGORIA_RECEITA_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB005_RECEBIMENTO",
                columns: table => new
                {
                    RECEBIMENTO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RECEBIMENTO_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RECEBIMENTO_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB005_RECEBIMENTO", x => x.RECEBIMENTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB006_FREQUENCIA",
                columns: table => new
                {
                    FREQUENCIA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FREQUENCIA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FREQUENCIA_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB006_FREQUENCIA", x => x.FREQUENCIA_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB008_CATEGORIA_DESPESA",
                columns: table => new
                {
                    CATEGORIA_DESPESA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORIA_DESPESA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CATEGORIA_DESPESA_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB008_CATEGORIA_DESPESA", x => x.CATEGORIA_DESPESA_ID);
                });

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
                name: "TB015_STATUS_PAGAMENTO",
                columns: table => new
                {
                    STATUS_PAGAMENTO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATUS_PAGAMENTO_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS_PAGAMENTO_STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB015_STATUS_PAGAMENTO", x => x.STATUS_PAGAMENTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB004_TIPO_ORIGEM_DINHEIRO",
                columns: table => new
                {
                    TIPO_ORIGEM_DINHEIRO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORIA_RECEITA_ID = table.Column<int>(type: "int", nullable: false),
                    TIPO_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIPO_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB004_TIPO_ORIGEM_DINHEIRO", x => x.TIPO_ORIGEM_DINHEIRO_ID);
                    table.ForeignKey(
                        name: "FK_TB004_TIPO_ORIGEM_DINHEIRO_TB003_CATEGORIA_RECEITA_CATEGORIA_RECEITA_ID",
                        column: x => x.CATEGORIA_RECEITA_ID,
                        principalTable: "TB003_CATEGORIA_RECEITA",
                        principalColumn: "CATEGORIA_RECEITA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB009_TIPO_DESPESA",
                columns: table => new
                {
                    TIPO_DESPESA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORIA_DESPESA_ID = table.Column<int>(type: "int", nullable: false),
                    TIPO_DESPESA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB009_TIPO_DESPESA", x => x.TIPO_DESPESA_ID);
                    table.ForeignKey(
                        name: "FK_TB009_TIPO_DESPESA_TB008_CATEGORIA_DESPESA_CATEGORIA_DESPESA_ID",
                        column: x => x.CATEGORIA_DESPESA_ID,
                        principalTable: "TB008_CATEGORIA_DESPESA",
                        principalColumn: "CATEGORIA_DESPESA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB013_ITEM_PRODUTO_COMPRA",
                columns: table => new
                {
                    ITEM_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEM_PRODUTO_COMPRA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CATEGORIA_PRODUTO_COMPRA_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB013_ITEM_PRODUTO_COMPRA", x => x.ITEM_PRODUTO_COMPRA_ID);
                    table.ForeignKey(
                        name: "FK_TB013_ITEM_PRODUTO_COMPRA_TB011_CATEGORIA_PRODUTO_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID",
                        column: x => x.CATEGORIA_PRODUTO_COMPRA_ID,
                        principalTable: "TB011_CATEGORIA_PRODUTO_COMPRA",
                        principalColumn: "CATEGORIA_PRODUTO_COMPRA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB010_DESPESA",
                columns: table => new
                {
                    DESPESA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO_ID = table.Column<int>(type: "int", nullable: false),
                    CATEGORIA_DESPESA_ID = table.Column<int>(type: "int", nullable: false),
                    FREQUENCIA_ID = table.Column<int>(type: "int", nullable: false),
                    STATUS_PAGAMENTO_ID = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    DESPESA_DESCRICAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DESPESA_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DATA_VENCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB010_DESPESA", x => x.DESPESA_ID);
                    table.ForeignKey(
                        name: "FK_TB010_DESPESA_TB006_FREQUENCIA_FREQUENCIA_ID",
                        column: x => x.FREQUENCIA_ID,
                        principalTable: "TB006_FREQUENCIA",
                        principalColumn: "FREQUENCIA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB010_DESPESA_TB008_CATEGORIA_DESPESA_CATEGORIA_DESPESA_ID",
                        column: x => x.CATEGORIA_DESPESA_ID,
                        principalTable: "TB008_CATEGORIA_DESPESA",
                        principalColumn: "CATEGORIA_DESPESA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB010_DESPESA_TB015_STATUS_PAGAMENTO_STATUS_PAGAMENTO_ID",
                        column: x => x.STATUS_PAGAMENTO_ID,
                        principalTable: "TB015_STATUS_PAGAMENTO",
                        principalColumn: "STATUS_PAGAMENTO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB007_RECEITA",
                columns: table => new
                {
                    RECEITA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO_ID = table.Column<int>(type: "int", nullable: false),
                    TIPO_ORIGEM_DINHEIRO_ID = table.Column<int>(type: "int", nullable: false),
                    RECEBIMENTO_ID = table.Column<int>(type: "int", nullable: false),
                    FREQUENCIA_ID = table.Column<int>(type: "int", nullable: false),
                    RECEITA_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TB003_Categoria_ReceitacategoriaReceita_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB007_RECEITA", x => x.RECEITA_ID);
                    table.ForeignKey(
                        name: "FK_TB007_RECEITA_TB003_CATEGORIA_RECEITA_TB003_Categoria_ReceitacategoriaReceita_Id",
                        column: x => x.TB003_Categoria_ReceitacategoriaReceita_Id,
                        principalTable: "TB003_CATEGORIA_RECEITA",
                        principalColumn: "CATEGORIA_RECEITA_ID");
                    table.ForeignKey(
                        name: "FK_TB007_RECEITA_TB004_TIPO_ORIGEM_DINHEIRO_TIPO_ORIGEM_DINHEIRO_ID",
                        column: x => x.TIPO_ORIGEM_DINHEIRO_ID,
                        principalTable: "TB004_TIPO_ORIGEM_DINHEIRO",
                        principalColumn: "TIPO_ORIGEM_DINHEIRO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB007_RECEITA_TB005_RECEBIMENTO_RECEBIMENTO_ID",
                        column: x => x.RECEBIMENTO_ID,
                        principalTable: "TB005_RECEBIMENTO",
                        principalColumn: "RECEBIMENTO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB007_RECEITA_TB006_FREQUENCIA_FREQUENCIA_ID",
                        column: x => x.FREQUENCIA_ID,
                        principalTable: "TB006_FREQUENCIA",
                        principalColumn: "FREQUENCIA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_TB004_TIPO_ORIGEM_DINHEIRO_CATEGORIA_RECEITA_ID",
                table: "TB004_TIPO_ORIGEM_DINHEIRO",
                column: "CATEGORIA_RECEITA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB007_RECEITA_FREQUENCIA_ID",
                table: "TB007_RECEITA",
                column: "FREQUENCIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB007_RECEITA_RECEBIMENTO_ID",
                table: "TB007_RECEITA",
                column: "RECEBIMENTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB007_RECEITA_TB003_Categoria_ReceitacategoriaReceita_Id",
                table: "TB007_RECEITA",
                column: "TB003_Categoria_ReceitacategoriaReceita_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TB007_RECEITA_TIPO_ORIGEM_DINHEIRO_ID",
                table: "TB007_RECEITA",
                column: "TIPO_ORIGEM_DINHEIRO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB009_TIPO_DESPESA_CATEGORIA_DESPESA_ID",
                table: "TB009_TIPO_DESPESA",
                column: "CATEGORIA_DESPESA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB010_DESPESA_CATEGORIA_DESPESA_ID",
                table: "TB010_DESPESA",
                column: "CATEGORIA_DESPESA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB010_DESPESA_FREQUENCIA_ID",
                table: "TB010_DESPESA",
                column: "FREQUENCIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB010_DESPESA_STATUS_PAGAMENTO_ID",
                table: "TB010_DESPESA",
                column: "STATUS_PAGAMENTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB013_ITEM_PRODUTO_COMPRA_CATEGORIA_PRODUTO_COMPRA_ID",
                table: "TB013_ITEM_PRODUTO_COMPRA",
                column: "CATEGORIA_PRODUTO_COMPRA_ID");

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
                name: "TB007_RECEITA");

            migrationBuilder.DropTable(
                name: "TB009_TIPO_DESPESA");

            migrationBuilder.DropTable(
                name: "TB010_DESPESA");

            migrationBuilder.DropTable(
                name: "TB014_ITEM_COMPRA");

            migrationBuilder.DropTable(
                name: "TB004_TIPO_ORIGEM_DINHEIRO");

            migrationBuilder.DropTable(
                name: "TB005_RECEBIMENTO");

            migrationBuilder.DropTable(
                name: "TB006_FREQUENCIA");

            migrationBuilder.DropTable(
                name: "TB008_CATEGORIA_DESPESA");

            migrationBuilder.DropTable(
                name: "TB015_STATUS_PAGAMENTO");

            migrationBuilder.DropTable(
                name: "TB012_UNIDADE_PRODUTO_COMPRA");

            migrationBuilder.DropTable(
                name: "TB013_ITEM_PRODUTO_COMPRA");

            migrationBuilder.DropTable(
                name: "TB003_CATEGORIA_RECEITA");

            migrationBuilder.DropTable(
                name: "TB011_CATEGORIA_PRODUTO_COMPRA");
        }
    }
}
