using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SebastianLargo_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SL_modelo1",
                columns: table => new
                {
                    SLPerfilID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SLDecimal = table.Column<int>(type: "int", nullable: false),
                    SLNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SLCaracter = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SL_modelo1", x => x.SLPerfilID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SL_modelo1");
        }
    }
}
