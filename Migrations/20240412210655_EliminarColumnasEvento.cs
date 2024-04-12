using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorEventos.Migrations
{
    /// <inheritdoc />
    public partial class EliminarColumnasEvento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Evento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Evento",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
