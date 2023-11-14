using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionRelacionesSiniestros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Siniestros_IdUbicacion",
                table: "Siniestros");

            migrationBuilder.AddColumn<int>(
                name: "SiniestrosIdSiniestro",
                table: "Ubicaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_SiniestrosIdSiniestro",
                table: "Ubicaciones",
                column: "SiniestrosIdSiniestro");

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_IdUbicacion",
                table: "Siniestros",
                column: "IdUbicacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Ubicaciones_Siniestros_SiniestrosIdSiniestro",
                table: "Ubicaciones",
                column: "SiniestrosIdSiniestro",
                principalTable: "Siniestros",
                principalColumn: "IdSiniestro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ubicaciones_Siniestros_SiniestrosIdSiniestro",
                table: "Ubicaciones");

            migrationBuilder.DropIndex(
                name: "IX_Ubicaciones_SiniestrosIdSiniestro",
                table: "Ubicaciones");

            migrationBuilder.DropIndex(
                name: "IX_Siniestros_IdUbicacion",
                table: "Siniestros");

            migrationBuilder.DropColumn(
                name: "SiniestrosIdSiniestro",
                table: "Ubicaciones");

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_IdUbicacion",
                table: "Siniestros",
                column: "IdUbicacion",
                unique: true);
        }
    }
}
