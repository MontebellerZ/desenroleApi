using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desenroleApi.Migrations
{
    /// <inheritdoc />
    public partial class UsuariosEGuids : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Faturas_FaturaId",
                table: "Gastos");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Gastos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Gastos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Gastos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Faturas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Faturas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Faturas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_UsuarioId",
                table: "Gastos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturas_UsuarioId",
                table: "Faturas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faturas_Usuario_UsuarioId",
                table: "Faturas",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Faturas_FaturaId",
                table: "Gastos",
                column: "FaturaId",
                principalTable: "Faturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Usuario_UsuarioId",
                table: "Gastos",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturas_Usuario_UsuarioId",
                table: "Faturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Faturas_FaturaId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Usuario_UsuarioId",
                table: "Gastos");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_UsuarioId",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Faturas_UsuarioId",
                table: "Faturas");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Faturas");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Faturas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Faturas");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Faturas_FaturaId",
                table: "Gastos",
                column: "FaturaId",
                principalTable: "Faturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
