using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgramacionWeb_Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class _10102023PersonasActu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Puestodetrabajo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RFC",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Puestodetrabajo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RFC",
                table: "Personas");
        }
    }
}
