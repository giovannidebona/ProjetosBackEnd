using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Sistemarcas.Infrastructure.Migrations
{
    public partial class AddTableDevsToTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Processos_Situacoes_Processosituacaoid",
                table: "Processos");

            migrationBuilder.DropIndex(
                name: "IX_Processos_Processosituacaoid",
                table: "Processos");

            migrationBuilder.DropColumn(
                name: "Processosituacaoid",
                table: "Processos");

            migrationBuilder.CreateTable(
                name: "Dev",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Squad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Login = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dev", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Situacaoregistroid",
                table: "Processos",
                column: "Situacaoregistroid");

            migrationBuilder.CreateIndex(
                name: "IX_Dev_Email",
                table: "Dev",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dev_Login",
                table: "Dev",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dev_Name",
                table: "Dev",
                column: "Name");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Processos_SituacoesRegistro_Situacaoregistroid",
            //    table: "Processos",
            //    column: "Situacaoregistroid",
            //    principalTable: "SituacoesRegistro",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_SituacoesRegistro_Situacaoregistroid",
                table: "Processos");

            migrationBuilder.DropTable(
                name: "Dev");

            migrationBuilder.DropIndex(
                name: "IX_Processos_Situacaoregistroid",
                table: "Processos");

            migrationBuilder.AddColumn<int>(
                name: "Processosituacaoid",
                table: "Processos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Processosituacaoid",
                table: "Processos",
                column: "Processosituacaoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Processos_Processos_Situacoes_Processosituacaoid",
                table: "Processos",
                column: "Processosituacaoid",
                principalTable: "Processos_Situacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
