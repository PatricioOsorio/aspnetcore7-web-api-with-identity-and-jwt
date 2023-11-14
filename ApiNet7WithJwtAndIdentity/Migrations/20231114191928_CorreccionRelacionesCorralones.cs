using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionRelacionesCorralones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Corralones_IdCorralonero",
                table: "Corralones");

            migrationBuilder.DropIndex(
                name: "IX_Corralones_IdRegion",
                table: "Corralones");

            migrationBuilder.DropIndex(
                name: "IX_Corralones_IdUbicacion",
                table: "Corralones");

            migrationBuilder.AddColumn<int>(
                name: "CorralonesIdCorralon",
                table: "Ubicaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorralonesIdCorralon",
                table: "Regiones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorralonesIdCorralon",
                table: "Corraloneros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_CorralonesIdCorralon",
                table: "Ubicaciones",
                column: "CorralonesIdCorralon");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_CorralonesIdCorralon",
                table: "Regiones",
                column: "CorralonesIdCorralon");

            migrationBuilder.CreateIndex(
                name: "IX_Corralones_IdCorralonero",
                table: "Corralones",
                column: "IdCorralonero");

            migrationBuilder.CreateIndex(
                name: "IX_Corralones_IdRegion",
                table: "Corralones",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Corralones_IdUbicacion",
                table: "Corralones",
                column: "IdUbicacion");

            migrationBuilder.CreateIndex(
                name: "IX_Corraloneros_CorralonesIdCorralon",
                table: "Corraloneros",
                column: "CorralonesIdCorralon");

            migrationBuilder.AddForeignKey(
                name: "FK_Corraloneros_Corralones_CorralonesIdCorralon",
                table: "Corraloneros",
                column: "CorralonesIdCorralon",
                principalTable: "Corralones",
                principalColumn: "IdCorralon");

            migrationBuilder.AddForeignKey(
                name: "FK_Regiones_Corralones_CorralonesIdCorralon",
                table: "Regiones",
                column: "CorralonesIdCorralon",
                principalTable: "Corralones",
                principalColumn: "IdCorralon");

            migrationBuilder.AddForeignKey(
                name: "FK_Ubicaciones_Corralones_CorralonesIdCorralon",
                table: "Ubicaciones",
                column: "CorralonesIdCorralon",
                principalTable: "Corralones",
                principalColumn: "IdCorralon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corraloneros_Corralones_CorralonesIdCorralon",
                table: "Corraloneros");

            migrationBuilder.DropForeignKey(
                name: "FK_Regiones_Corralones_CorralonesIdCorralon",
                table: "Regiones");

            migrationBuilder.DropForeignKey(
                name: "FK_Ubicaciones_Corralones_CorralonesIdCorralon",
                table: "Ubicaciones");

            migrationBuilder.DropIndex(
                name: "IX_Ubicaciones_CorralonesIdCorralon",
                table: "Ubicaciones");

            migrationBuilder.DropIndex(
                name: "IX_Regiones_CorralonesIdCorralon",
                table: "Regiones");

            migrationBuilder.DropIndex(
                name: "IX_Corralones_IdCorralonero",
                table: "Corralones");

            migrationBuilder.DropIndex(
                name: "IX_Corralones_IdRegion",
                table: "Corralones");

            migrationBuilder.DropIndex(
                name: "IX_Corralones_IdUbicacion",
                table: "Corralones");

            migrationBuilder.DropIndex(
                name: "IX_Corraloneros_CorralonesIdCorralon",
                table: "Corraloneros");

            migrationBuilder.DropColumn(
                name: "CorralonesIdCorralon",
                table: "Ubicaciones");

            migrationBuilder.DropColumn(
                name: "CorralonesIdCorralon",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "CorralonesIdCorralon",
                table: "Corraloneros");

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
    }
}
