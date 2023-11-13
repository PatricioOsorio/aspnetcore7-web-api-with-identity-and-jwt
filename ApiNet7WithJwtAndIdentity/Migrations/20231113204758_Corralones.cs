using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class Corralones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Regiones",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.CreateTable(
                name: "Corralones",
                columns: table => new
                {
                    IdCorralon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiasActivo = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    IdRegion = table.Column<int>(type: "int", nullable: false),
                    IdUbicacion = table.Column<int>(type: "int", nullable: false),
                    IdCorralonero = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corralones", x => x.IdCorralon);
                    table.ForeignKey(
                        name: "FK_Corralones_Corraloneros_IdCorralonero",
                        column: x => x.IdCorralonero,
                        principalTable: "Corraloneros",
                        principalColumn: "IdCorralonero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corralones_Regiones_IdRegion",
                        column: x => x.IdRegion,
                        principalTable: "Regiones",
                        principalColumn: "IdRegion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corralones_Ubicaciones_IdUbicacion",
                        column: x => x.IdUbicacion,
                        principalTable: "Ubicaciones",
                        principalColumn: "IdUbicacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corralones_IdCorralonero",
                table: "Corralones",
                column: "IdCorralonero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Corralones_IdRegion",
                table: "Corralones",
                column: "IdRegion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Corralones_IdUbicacion",
                table: "Corralones",
                column: "IdUbicacion",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Corralones");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Regiones",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
