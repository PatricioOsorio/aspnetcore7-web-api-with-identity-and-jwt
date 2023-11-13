using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class Siniestros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    IdRegion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.IdRegion);
                });

            migrationBuilder.CreateTable(
                name: "TipoGruas",
                columns: table => new
                {
                    IdTipoGruas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoGruas", x => x.IdTipoGruas);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    IdUbicacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitud = table.Column<float>(type: "real", nullable: false),
                    Longitud = table.Column<float>(type: "real", nullable: false),
                    Cp = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NumeroExterior = table.Column<int>(type: "int", nullable: true),
                    NumeroInterior = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.IdUbicacion);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.IdVehiculo);
                });

            migrationBuilder.CreateTable(
                name: "Siniestros",
                columns: table => new
                {
                    IdSiniestro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Folio = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Detalles = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    IdAsesor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUbicacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniestros", x => x.IdSiniestro);
                    table.ForeignKey(
                        name: "FK_Siniestros_Asesores_IdAsesor",
                        column: x => x.IdAsesor,
                        principalTable: "Asesores",
                        principalColumn: "IdAsesor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siniestros_Ubicaciones_IdUbicacion",
                        column: x => x.IdUbicacion,
                        principalTable: "Ubicaciones",
                        principalColumn: "IdUbicacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_IdAsesor",
                table: "Siniestros",
                column: "IdAsesor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_IdUbicacion",
                table: "Siniestros",
                column: "IdUbicacion",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "Siniestros");

            migrationBuilder.DropTable(
                name: "TipoGruas");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Ubicaciones");
        }
    }
}
