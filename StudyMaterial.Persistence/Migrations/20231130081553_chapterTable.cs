using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMaterial.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class chapterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChapterNo",
                table: "chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChapterNo",
                table: "chapters");
        }
    }
}
