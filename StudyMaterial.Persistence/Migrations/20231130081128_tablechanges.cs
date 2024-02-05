using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMaterial.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class tablechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Programs_ProgramId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ProgramId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Subjects");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "chapters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "chapters");

            migrationBuilder.AddColumn<Guid>(
                name: "ProgramId",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ProgramId",
                table: "Subjects",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Programs_ProgramId",
                table: "Subjects",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
