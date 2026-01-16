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
            migrationBuilder.AlterColumn<bool>(
                name: "ATIVO",
                table: "TB007_RECEITA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ATIVO",
                table: "TB007_RECEITA",
                type: "float",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
