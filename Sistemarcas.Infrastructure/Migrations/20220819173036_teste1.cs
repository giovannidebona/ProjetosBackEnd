using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Sistemarcas.Infrastructure.Migrations
{
    public partial class teste1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Itens_Classes_ClassesId",
                table: "Classes_Itens");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Itens_ClassesId",
                table: "Classes_Itens");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Classes_Itens");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Itens_Classeid",
                table: "Classes_Itens",
                column: "Classeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Itens_Classes_Classeid",
                table: "Classes_Itens",
                column: "Classeid",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Itens_Classes_Classeid",
                table: "Classes_Itens");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Itens_Classeid",
                table: "Classes_Itens");

            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Classes_Itens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Itens_ClassesId",
                table: "Classes_Itens",
                column: "ClassesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Itens_Classes_ClassesId",
                table: "Classes_Itens",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
