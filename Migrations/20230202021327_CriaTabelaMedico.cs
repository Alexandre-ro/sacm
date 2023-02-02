using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SACM.Migrations
{
    public partial class CriaTabelaMedico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "medico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codigo_especialidade = table.Column<int>(type: "int", nullable: false),
                    crm = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    instituicao_formatura = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ano_formatura = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    ano_nascimento = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    mes_nascimento = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    dia_nascimento = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico", x => x.id);
                    table.ForeignKey(
                        name: "FK_medico_especialidade_codigo_especialidade",
                        column: x => x.codigo_especialidade,
                        principalTable: "especialidade",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_medico_codigo_especialidade",
                table: "medico",
                column: "codigo_especialidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medico");
        }
    }
}
