using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaEquipamento.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
