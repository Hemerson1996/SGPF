using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGFP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init03 : Migration
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
                name: "TB007_RECEITA",
                columns: table => new
                {
                    RECEITA_ID = table.Column<int>(type: "int", nullable: false),
                    USUARIO_ID = table.Column<int>(type: "int", nullable: false),
                    CATEGORIA_RECEITA_ID = table.Column<int>(type: "int", nullable: false),
                    RECEBIMENTO_ID = table.Column<int>(type: "int", nullable: false),
                    frequencia_Id = table.Column<int>(type: "int", nullable: false),
                    RECEITA_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB007_RECEITA", x => x.RECEITA_ID);
                    table.ForeignKey(
                        name: "FK_TB007_RECEITA_TB003_CATEGORIA_RECEITA_RECEITA_ID",
                        column: x => x.RECEITA_ID,
                        principalTable: "TB003_CATEGORIA_RECEITA",
                        principalColumn: "CATEGORIA_RECEITA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB007_RECEITA_TB005_RECEBIMENTO_RECEBIMENTO_ID",
                        column: x => x.RECEBIMENTO_ID,
                        principalTable: "TB005_RECEBIMENTO",
                        principalColumn: "RECEBIMENTO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB007_RECEITA_TB006_FREQUENCIA_frequencia_Id",
                        column: x => x.frequencia_Id,
                        principalTable: "TB006_FREQUENCIA",
                        principalColumn: "FREQUENCIA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB004_TIPO_ORIGEM_DINHEIRO_CATEGORIA_RECEITA_ID",
                table: "TB004_TIPO_ORIGEM_DINHEIRO",
                column: "CATEGORIA_RECEITA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB007_RECEITA_frequencia_Id",
                table: "TB007_RECEITA",
                column: "frequencia_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TB007_RECEITA_RECEBIMENTO_ID",
                table: "TB007_RECEITA",
                column: "RECEBIMENTO_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB004_TIPO_ORIGEM_DINHEIRO");

            migrationBuilder.DropTable(
                name: "TB007_RECEITA");

            migrationBuilder.DropTable(
                name: "TB003_CATEGORIA_RECEITA");

            migrationBuilder.DropTable(
                name: "TB005_RECEBIMENTO");

            migrationBuilder.DropTable(
                name: "TB006_FREQUENCIA");
        }
    }
}
