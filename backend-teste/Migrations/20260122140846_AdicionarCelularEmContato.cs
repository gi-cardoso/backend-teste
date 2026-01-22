using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_teste.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCelularEmContato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Contatos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Contatos");
        }
    }
}
