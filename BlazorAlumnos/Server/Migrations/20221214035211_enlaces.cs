using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAlumnos.Server.Migrations
{
    public partial class enlaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "Materias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_AlumnoId",
                table: "Materias",
                column: "AlumnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Alumnos_AlumnoId",
                table: "Materias",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Alumnos_AlumnoId",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_AlumnoId",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "Materias");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
