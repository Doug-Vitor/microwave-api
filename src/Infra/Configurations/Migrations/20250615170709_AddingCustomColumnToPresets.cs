using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Configurations.Migrations
{
    /// <inheritdoc />
    public partial class AddingCustomColumnToPresets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Custom",
                table: "Preset",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Custom",
                table: "Preset");
        }
    }
}
