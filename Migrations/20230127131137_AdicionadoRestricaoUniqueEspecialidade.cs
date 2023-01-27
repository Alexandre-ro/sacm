using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SACM.Migrations
{
    public partial class AdicionadoRestricaoUniqueEspecialidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_especialidade_nome",
                table: "especialidade",
                column: "nome");

            migrationBuilder.CreateIndex(
                name: "IX_especialidade_nome",
                table: "especialidade",
                column: "nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_especialidade_nome",
                table: "especialidade");

            migrationBuilder.DropIndex(
                name: "IX_especialidade_nome",
                table: "especialidade");
        }
    }
}
