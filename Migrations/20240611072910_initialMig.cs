using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace abs38.Migrations
{
    /// <inheritdoc />
    public partial class initialMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "projektbeteiligten",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Straße = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hausnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PLZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anmerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geburtstag = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projektbeteiligten", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projektbeteiligten");
        }
    }
}
