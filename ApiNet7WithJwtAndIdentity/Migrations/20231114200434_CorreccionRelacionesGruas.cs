using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionRelacionesGruas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gruas_TipoGruas_IdTipoGruas",
                table: "Gruas");

            migrationBuilder.DropIndex(
                name: "IX_Gruas_IdTipoGruas",
                table: "Gruas");

            migrationBuilder.RenameColumn(
                name: "IdTipoGruas",
                table: "TipoGruas",
                newName: "IdTipoGrua");

            migrationBuilder.RenameColumn(
                name: "IdTipoGruas",
                table: "Gruas",
                newName: "IdTipoGrua");

            migrationBuilder.CreateIndex(
                name: "IX_Gruas_IdTipoGrua",
                table: "Gruas",
                column: "IdTipoGrua");

            migrationBuilder.AddForeignKey(
                name: "FK_Gruas_TipoGruas_IdTipoGrua",
                table: "Gruas",
                column: "IdTipoGrua",
                principalTable: "TipoGruas",
                principalColumn: "IdTipoGrua",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gruas_TipoGruas_IdTipoGrua",
                table: "Gruas");

            migrationBuilder.DropIndex(
                name: "IX_Gruas_IdTipoGrua",
                table: "Gruas");

            migrationBuilder.RenameColumn(
                name: "IdTipoGrua",
                table: "TipoGruas",
                newName: "IdTipoGruas");

            migrationBuilder.RenameColumn(
                name: "IdTipoGrua",
                table: "Gruas",
                newName: "IdTipoGruas");

            migrationBuilder.CreateIndex(
                name: "IX_Gruas_IdTipoGruas",
                table: "Gruas",
                column: "IdTipoGruas",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gruas_TipoGruas_IdTipoGruas",
                table: "Gruas",
                column: "IdTipoGruas",
                principalTable: "TipoGruas",
                principalColumn: "IdTipoGruas",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
