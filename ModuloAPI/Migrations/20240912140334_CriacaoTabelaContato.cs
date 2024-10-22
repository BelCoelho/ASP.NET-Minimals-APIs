﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuloAPI.Migrations
{
    public partial class CriacaoTabelaContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        //Aplica as mudanças no banco de dados
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        //Remove as mudanças na tabela
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
