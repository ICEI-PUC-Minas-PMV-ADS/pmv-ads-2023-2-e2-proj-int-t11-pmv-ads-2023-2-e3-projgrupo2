using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EassyDental.Migrations
{
    public partial class N01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioDentista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome_da_clinica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereço = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorarioAtendimentoInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorarioAtendimentoFim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioDentista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgendaEventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioClienteId = table.Column<int>(type: "int", nullable: false),
                    UsuarioDentistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaEventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaEventos_UsuarioCliente_UsuarioClienteId",
                        column: x => x.UsuarioClienteId,
                        principalTable: "UsuarioCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgendaEventos_UsuarioDentista_UsuarioDentistaId",
                        column: x => x.UsuarioDentistaId,
                        principalTable: "UsuarioDentista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEventos_UsuarioClienteId",
                table: "AgendaEventos",
                column: "UsuarioClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEventos_UsuarioDentistaId",
                table: "AgendaEventos",
                column: "UsuarioDentistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaEventos");

            migrationBuilder.DropTable(
                name: "UsuarioCliente");

            migrationBuilder.DropTable(
                name: "UsuarioDentista");
        }
    }
}
