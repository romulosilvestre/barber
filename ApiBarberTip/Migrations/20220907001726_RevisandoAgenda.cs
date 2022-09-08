using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBarberTip.Migrations
{
    public partial class RevisandoAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Clientes_ClienteId",
                table: "Agendamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendamento",
                table: "Agendamento");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_ClienteId",
                table: "Agendamento");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Agendamento");

            migrationBuilder.RenameTable(
                name: "Agendamento",
                newName: "Agendamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_IdCliente",
                table: "Agendamentos",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Clientes_IdCliente",
                table: "Agendamentos",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Clientes_IdCliente",
                table: "Agendamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_IdCliente",
                table: "Agendamentos");

            migrationBuilder.RenameTable(
                name: "Agendamentos",
                newName: "Agendamento");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Agendamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendamento",
                table: "Agendamento",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ClienteId",
                table: "Agendamento",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Clientes_ClienteId",
                table: "Agendamento",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
