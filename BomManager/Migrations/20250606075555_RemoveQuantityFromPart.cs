using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BomManager.Migrations
{
    /// <inheritdoc />
    public partial class RemoveQuantityFromPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Parts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Parts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
