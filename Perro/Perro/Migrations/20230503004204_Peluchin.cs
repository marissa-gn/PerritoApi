using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Perro.Migrations
{
    /// <inheritdoc />
    public partial class Peluchin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Razas",
                columns: table => new
                {
                    IdRaza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razas", x => x.IdRaza);
                });

            migrationBuilder.CreateTable(
                name: "Sexos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nombres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRaza = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nombres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nombres_Razas_IdRaza",
                        column: x => x.IdRaza,
                        principalTable: "Razas",
                        principalColumn: "IdRaza",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Razas",
                columns: new[] { "IdRaza", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Soy un Bulldog", "Bulldog" },
                    { 2, "Soy un Labrador", "Labrador" },
                    { 3, "Soy un Golden retriever", "Golden retriever" },
                    { 4, "Soy un Pastor Aleman", "Pastor aleman" },
                    { 5, "Soy un Husky", "Husky" }
                });

            migrationBuilder.InsertData(
                table: "Sexos",
                columns: new[] { "Id", "Genero" },
                values: new object[,]
                {
                    { 1, "Macho" },
                    { 2, "Hembra" }
                });

            migrationBuilder.InsertData(
                table: "Nombres",
                columns: new[] { "Id", "IdRaza", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Jumbo" },
                    { 2, 3, "Bolillo" },
                    { 3, 4, "Luna" },
                    { 4, 1, "Dogui" },
                    { 5, 2, "Chikis" },
                    { 6, 1, "Pato" },
                    { 7, 2, "Taco" },
                    { 8, 3, "Pulgoso" },
                    { 9, 4, "Solovino" },
                    { 10, 5, "Firulais" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nombres_IdRaza",
                table: "Nombres",
                column: "IdRaza");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nombres");

            migrationBuilder.DropTable(
                name: "Sexos");

            migrationBuilder.DropTable(
                name: "Razas");
        }
    }
}
