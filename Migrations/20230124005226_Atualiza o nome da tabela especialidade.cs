using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SACM.Migrations
{
    public partial class Atualizaonomedatabelaespecialidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_especialiade",
                table: "especialiade");

            migrationBuilder.RenameTable(
                name: "especialiade",
                newName: "especialidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_especialidade",
                table: "especialidade",
                column: "codigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_especialidade",
                table: "especialidade");

            migrationBuilder.RenameTable(
                name: "especialidade",
                newName: "especialiade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_especialiade",
                table: "especialiade",
                column: "codigo");
        }
    }
}
