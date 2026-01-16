using System;
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
            migrationBuilder.AddColumn<double>(
                name: "ATIVO",
                table: "TB007_RECEITA",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_FIM",
                table: "TB007_RECEITA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_INICIO",
                table: "TB007_RECEITA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ATIVO",
                table: "TB007_RECEITA");

            migrationBuilder.DropColumn(
                name: "DATA_FIM",
                table: "TB007_RECEITA");

            migrationBuilder.DropColumn(
                name: "DATA_INICIO",
                table: "TB007_RECEITA");
        }
    }
}
