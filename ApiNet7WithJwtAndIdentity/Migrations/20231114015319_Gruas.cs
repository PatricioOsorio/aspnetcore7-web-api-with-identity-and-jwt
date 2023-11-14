using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    /// <inheritdoc />
    public partial class Gruas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gruas",
                columns: table => new
                {
                    IdGrua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    IdCorralon = table.Column<int>(type: "int", nullable: false),
                    IdTipoGruas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gruas", x => x.IdGrua);
                    table.ForeignKey(
                        name: "FK_Gruas_Corralones_IdCorralon",
                        column: x => x.IdCorralon,
                        principalTable: "Corralones",
                        principalColumn: "IdCorralon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gruas_TipoGruas_IdTipoGruas",
                        column: x => x.IdTipoGruas,
                        principalTable: "TipoGruas",
                        principalColumn: "IdTipoGruas",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gruas_IdCorralon",
                table: "Gruas",
                column: "IdCorralon");

            migrationBuilder.CreateIndex(
                name: "IX_Gruas_IdTipoGruas",
                table: "Gruas",
                column: "IdTipoGruas",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gruas");
        }
    }
}
