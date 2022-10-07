using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Sistemarcas.Infrastructure.Migrations
{
    public partial class processoexterno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ProcessoExterno",
                table: "Processos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcessoExterno",
                table: "Processos");
        }
    }
}
