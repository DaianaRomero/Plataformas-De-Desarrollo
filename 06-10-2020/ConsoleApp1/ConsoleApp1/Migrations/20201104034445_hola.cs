﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class hola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Clave = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Estimacion = table.Column<string>(nullable: true, defaultValue: "0"),
                    RecursoId = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Tiempo = table.Column<string>(nullable: false),
                    RecursoId = table.Column<int>(nullable: false),
                    TareaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_TareaId",
                        column: x => x.TareaId,
                        principalTable: "Tarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_RecursoId",
                table: "Detalle",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_TareaId",
                table: "Detalle",
                column: "TareaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_UsuarioId",
                table: "Recurso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_RecursoId",
                table: "Tarea",
                column: "RecursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
