using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PastelariaDoZe.Infra.ORM.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBClientesBase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBClientesBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBFuncionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Salario = table.Column<double>(type: "FLOAT", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "DATE", nullable: false),
                    CpfFuncionario = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Usuario = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFuncionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    ValorUnitario = table.Column<double>(type: "FLOAT", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "DATE", nullable: false),
                    Quantidade = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBProdutos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBClientesCNPJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Cnpj = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBClientesCNPJ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBClientesCNPJ_TBClientesBase_Id",
                        column: x => x.Id,
                        principalTable: "TBClientesBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBClientesCPF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Cpf = table.Column<string>(type: "VARCHAR(14)", nullable: false),
                    Rg = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Cnh = table.Column<string>(type: "VARCHAR(12)", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBClientesCPF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBClientesCPF_TBClientesBase_Id",
                        column: x => x.Id,
                        principalTable: "TBClientesBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBClientesCPF_TBClientesCNPJ_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TBClientesCNPJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBClientesCPF_ClienteId",
                table: "TBClientesCPF",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBClientesCPF");

            migrationBuilder.DropTable(
                name: "TBFuncionarios");

            migrationBuilder.DropTable(
                name: "TBProdutos");

            migrationBuilder.DropTable(
                name: "TBClientesCNPJ");

            migrationBuilder.DropTable(
                name: "TBClientesBase");
        }
    }
}
