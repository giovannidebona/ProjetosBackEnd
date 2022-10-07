using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Sistemarcas.Infrastructure.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Despachos_Despachoid",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Pedidos_OrdemServicoId",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Servicos_Servicoid",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_TiposTarefas_Tipotarefaid",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_OrdemServicoId",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "OrdemServicoId",
                table: "Tarefas");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Pedidoid",
                table: "Tarefas",
                column: "Pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Despachos_Despachoid",
                table: "Tarefas",
                column: "Despachoid",
                principalTable: "Despachos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Pedidos_Pedidoid",
                table: "Tarefas",
                column: "Pedidoid",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Servicos_Servicoid",
                table: "Tarefas",
                column: "Servicoid",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_TiposTarefas_Tipotarefaid",
                table: "Tarefas",
                column: "Tipotarefaid",
                principalTable: "TiposTarefas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Despachos_Despachoid",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Pedidos_Pedidoid",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Servicos_Servicoid",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_TiposTarefas_Tipotarefaid",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_Pedidoid",
                table: "Tarefas");

            migrationBuilder.AddColumn<int>(
                name: "OrdemServicoId",
                table: "Tarefas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_OrdemServicoId",
                table: "Tarefas",
                column: "OrdemServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Despachos_Despachoid",
                table: "Tarefas",
                column: "Despachoid",
                principalTable: "Despachos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Pedidos_OrdemServicoId",
                table: "Tarefas",
                column: "OrdemServicoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Servicos_Servicoid",
                table: "Tarefas",
                column: "Servicoid",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_TiposTarefas_Tipotarefaid",
                table: "Tarefas",
                column: "Tipotarefaid",
                principalTable: "TiposTarefas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
