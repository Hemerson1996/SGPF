using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGFP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB011_DESPESA");

            migrationBuilder.CreateTable(
                name: "TB010_DESPESA",
                columns: table => new
                {
                    DESPESA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO_ID = table.Column<int>(type: "int", nullable: false),
                    CATEGORIA_DESPESA_ID = table.Column<int>(type: "int", nullable: false),
                    DESPESA_DESCRICAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DESPESA_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DATA_VENCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB010_DESPESA", x => x.DESPESA_ID);
                    table.ForeignKey(
                        name: "FK_TB010_DESPESA_TB008_CATEGORIA_DESPESA_CATEGORIA_DESPESA_ID",
                        column: x => x.CATEGORIA_DESPESA_ID,
                        principalTable: "TB008_CATEGORIA_DESPESA",
                        principalColumn: "CATEGORIA_DESPESA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB010_DESPESA_CATEGORIA_DESPESA_ID",
                table: "TB010_DESPESA",
                column: "CATEGORIA_DESPESA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB010_DESPESA");

            migrationBuilder.CreateTable(
                name: "TB011_DESPESA",
                columns: table => new
                {
                    DESPESA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORIA_DESPESA_ID = table.Column<int>(type: "int", nullable: false),
                    DATA_VENCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DESPESA_DESCRICAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DESPESA_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    USUARIO_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB011_DESPESA", x => x.DESPESA_ID);
                    table.ForeignKey(
                        name: "FK_TB011_DESPESA_TB008_CATEGORIA_DESPESA_CATEGORIA_DESPESA_ID",
                        column: x => x.CATEGORIA_DESPESA_ID,
                        principalTable: "TB008_CATEGORIA_DESPESA",
                        principalColumn: "CATEGORIA_DESPESA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB011_DESPESA_CATEGORIA_DESPESA_ID",
                table: "TB011_DESPESA",
                column: "CATEGORIA_DESPESA_ID");
        }
    }
}
