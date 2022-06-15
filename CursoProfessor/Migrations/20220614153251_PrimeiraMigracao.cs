using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoProfessor.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaDeCursos",
                columns: table => new
                {
                    cursos_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cursos_nome = table.Column<string>(nullable: true),
                    cursos_sala = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeCursos", x => x.cursos_id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeProfessores",
                columns: table => new
                {
                    professores_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    professores_nome = table.Column<string>(nullable: true),
                    professores_email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeProfessores", x => x.professores_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaDeCursos");

            migrationBuilder.DropTable(
                name: "TabelaDeProfessores");
        }
    }
}
