using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionRelacionesArrastres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdCorralon",
                table: "Arrastres");

            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdGrua",
                table: "Arrastres");

            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdSiniestro",
                table: "Arrastres");

            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdVehiculo",
                table: "Arrastres");

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdCorralon",
                table: "Arrastres",
                column: "IdCorralon");

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdGrua",
                table: "Arrastres",
                column: "IdGrua");

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdSiniestro",
                table: "Arrastres",
                column: "IdSiniestro");

            migrationBuilder.CreateIndex(
                name: "IX_Arrastres_IdVehiculo",
                table: "Arrastres",
                column: "IdVehiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdCorralon",
                table: "Arrastres");

            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdGrua",
                table: "Arrastres");

            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdSiniestro",
                table: "Arrastres");

            migrationBuilder.DropIndex(
                name: "IX_Arrastres_IdVehiculo",
                table: "Arrastres");

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
    }
}
