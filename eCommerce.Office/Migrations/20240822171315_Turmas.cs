using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Office.Migrations
{
    /// <inheritdoc />
    public partial class Turmas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6647), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6649), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 5 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6651), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6653), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6659), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 5 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6661), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 22, 14, 13, 13, 180, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Turma A1" },
                    { 2, "Turma A2" },
                    { 3, "Turma A3" },
                    { 4, "Turma A4" },
                    { 5, "Turma A5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8193), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 5 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8199), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8201), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 5 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8205), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8206), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
