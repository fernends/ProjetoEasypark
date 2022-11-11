using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEasypark.Migrations
{
    public partial class M00_Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cliente_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCarro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeloCarro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlacaCarro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro = table.Column<int>(type: "int", nullable: false),
                    TipoVaga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cliente_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
