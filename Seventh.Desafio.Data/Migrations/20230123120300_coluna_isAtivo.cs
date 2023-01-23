using Microsoft.EntityFrameworkCore.Migrations;

namespace Seventh.Desafio.Data.Migrations
{
    public partial class coluna_isAtivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAtivo",
                table: "Servidores",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAtivo",
                table: "Servidores");
        }
    }
}
