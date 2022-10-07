using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Sistemarcas.Infrastructure.Migrations
{
    public partial class AjusteFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Processofilhoid",
                table: "Processos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Pedidoid",
                table: "Processos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Empresaid",
                table: "Processos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Clienteid",
                table: "Processos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Clienteid",
                table: "Processos",
                column: "Clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Empresaid",
                table: "Processos",
                column: "Empresaid");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Processos_Clientes_Clienteid",
            //    table: "Processos",
            //    column: "Clienteid",
            //    principalTable: "Clientes",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Processos_Empresas_Empresaid",
            //    table: "Processos",
            //    column: "Empresaid",
            //    principalTable: "Empresas",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Clientes_Clienteid",
                table: "Processos");

            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Empresas_Empresaid",
                table: "Processos");

            migrationBuilder.DropIndex(
                name: "IX_Processos_Clienteid",
                table: "Processos");

            migrationBuilder.DropIndex(
                name: "IX_Processos_Empresaid",
                table: "Processos");

            migrationBuilder.AlterColumn<int>(
                name: "Processofilhoid",
                table: "Processos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Pedidoid",
                table: "Processos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Empresaid",
                table: "Processos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Clienteid",
                table: "Processos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
