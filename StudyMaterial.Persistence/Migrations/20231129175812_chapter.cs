using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMaterial.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class chapter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_chapters_SemesterId",
                table: "chapters",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_chapters_SubjectId",
                table: "chapters",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_chapters_Semesters_SemesterId",
                table: "chapters",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_chapters_Subjects_SubjectId",
                table: "chapters",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chapters_Semesters_SemesterId",
                table: "chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_chapters_Subjects_SubjectId",
                table: "chapters");

            migrationBuilder.DropIndex(
                name: "IX_chapters_SemesterId",
                table: "chapters");

            migrationBuilder.DropIndex(
                name: "IX_chapters_SubjectId",
                table: "chapters");
        }
    }
}
