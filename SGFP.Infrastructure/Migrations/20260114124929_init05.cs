using System;
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
            migrationBuilder.AddColumn<bool>(
                name: "ATIVO",
                table: "TB010_DESPESA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_FIM",
                table: "TB010_DESPESA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_INICIO",
                table: "TB010_DESPESA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ATIVO",
                table: "TB010_DESPESA");

            migrationBuilder.DropColumn(
                name: "DATA_FIM",
                table: "TB010_DESPESA");

            migrationBuilder.DropColumn(
                name: "DATA_INICIO",
                table: "TB010_DESPESA");
        }
    }
}
