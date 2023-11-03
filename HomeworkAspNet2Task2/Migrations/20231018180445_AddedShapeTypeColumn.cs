using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeworkAspNet2Task2.Migrations
{
    /// <inheritdoc />
    public partial class AddedShapeTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShapeType",
                table: "Shapes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShapeType",
                table: "Shapes");
        }
    }
}
