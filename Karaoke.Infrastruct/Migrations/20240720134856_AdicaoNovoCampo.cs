using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karaoke.Infrastruct.Migrations
{
    /// <inheritdoc />
    public partial class AdicaoNovoCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ordem",
                table: "Karaokes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordem",
                table: "Karaokes");
        }
    }
}
