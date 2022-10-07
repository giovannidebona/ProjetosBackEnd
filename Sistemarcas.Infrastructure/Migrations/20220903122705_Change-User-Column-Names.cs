using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Sistemarcas.Infrastructure.Migrations
{
    public partial class ChangeUserColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuario",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Usuario",
                newName: "Email");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Regras_Despachos_Processos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProcessoId",
                table: "Regras_Despachos_Processos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Processo_Id",
                table: "Regras_Despachos_Processos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Regras_Despachos_Processos_ProcessoId",
                table: "Regras_Despachos_Processos",
                column: "ProcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regras_Despachos_Processos_Processos_ProcessoId",
                table: "Regras_Despachos_Processos",
                column: "ProcessoId",
                principalTable: "Processos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regras_Despachos_Processos_Processos_ProcessoId",
                table: "Regras_Despachos_Processos");

            migrationBuilder.DropIndex(
                name: "IX_Regras_Despachos_Processos_ProcessoId",
                table: "Regras_Despachos_Processos");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Regras_Despachos_Processos");

            migrationBuilder.DropColumn(
                name: "ProcessoId",
                table: "Regras_Despachos_Processos");

            migrationBuilder.DropColumn(
                name: "Processo_Id",
                table: "Regras_Despachos_Processos");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuario",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuario",
                newName: "Login");
        }
    }
}
