using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class Arrastres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.CreateTable(
                name: "Arrastres",
                columns: table => new
                {
                    IdArrastre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KmRecorridos = table.Column<float>(type: "real", nullable: false),
                    CostoPorArrastre = table.Column<float>(type: "real", nullable: false),
                    CostoPorDia = table.Column<float>(type: "real", nullable: false),
                    IdSiniestro = table.Column<int>(type: "int", nullable: false),
                    IdVehiculo = table.Column<int>(type: "int", nullable: false),
                    IdGrua = table.Column<int>(type: "int", nullable: false),
                    IdCorralon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrastres", x => x.IdArrastre);
                    table.ForeignKey(
                        name: "FK_Arrastres_Corralones_IdCorralon",
                        column: x => x.IdCorralon,
                        principalTable: "Corralones",
                        principalColumn: "IdCorralon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arrastres_Gruas_IdGrua",
                        column: x => x.IdGrua,
                        principalTable: "Gruas",
                        principalColumn: "IdGrua",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arrastres_Siniestros_IdSiniestro",
                        column: x => x.IdSiniestro,
                        principalTable: "Siniestros",
                        principalColumn: "IdSiniestro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arrastres_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdCorralon",
                table: "Arrastres",
                column: "IdCorralon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdGrua",
                table: "Arrastres",
                column: "IdGrua",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdSiniestro",
                table: "Arrastres",
                column: "IdSiniestro",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdVehiculo",
                table: "Arrastres",
                column: "IdVehiculo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arrastres");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }
    }
}
