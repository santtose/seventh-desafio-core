using Microsoft.EntityFrameworkCore.Migrations;

namespace Seventh.Desafio.Data.Migrations
{
    public partial class coluna_isDisponivel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisponivel",
                table: "Servidores",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisponivel",
                table: "Servidores");
        }
    }
}
