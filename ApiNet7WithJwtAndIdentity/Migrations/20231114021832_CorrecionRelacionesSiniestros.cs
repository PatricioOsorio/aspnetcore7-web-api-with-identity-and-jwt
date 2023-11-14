using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionRelacionesSiniestros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Siniestros_IdAsesor",
                table: "Siniestros");

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_IdAsesor",
                table: "Siniestros",
                column: "IdAsesor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Siniestros_IdAsesor",
                table: "Siniestros");

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_IdAsesor",
                table: "Siniestros",
                column: "IdAsesor",
                unique: true);
        }
    }
}
