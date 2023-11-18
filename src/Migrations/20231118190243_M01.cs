using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EassyDental.Migrations
{
    public partial class M01 : Migration
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
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidade = table.Column<int>(type: "int", nullable: false),
                    NomeClinica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioAbertura = table.Column<TimeSpan>(type: "time", nullable: false),
                    HorarioEncerramento = table.Column<TimeSpan>(type: "time", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioDentista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgendaEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HorarioConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioClienteId = table.Column<int>(type: "int", nullable: false),
                    UsuarioDentistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaEvento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaEvento_UsuarioCliente_UsuarioClienteId",
                        column: x => x.UsuarioClienteId,
                        principalTable: "UsuarioCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgendaEvento_UsuarioDentista_UsuarioDentistaId",
                        column: x => x.UsuarioDentistaId,
                        principalTable: "UsuarioDentista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEvento_UsuarioClienteId",
                table: "AgendaEvento",
                column: "UsuarioClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEvento_UsuarioDentistaId",
                table: "AgendaEvento",
                column: "UsuarioDentistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaEvento");

            migrationBuilder.DropTable(
                name: "UsuarioCliente");

            migrationBuilder.DropTable(
                name: "UsuarioDentista");
        }
    }
}
