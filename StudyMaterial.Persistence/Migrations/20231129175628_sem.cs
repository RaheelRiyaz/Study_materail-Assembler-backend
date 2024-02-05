using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMaterial.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Programs_ProgramId",
                table: "Semesters");

            migrationBuilder.DropIndex(
                name: "IX_Semesters_ProgramId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Semesters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProgramId",
                table: "Semesters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_ProgramId",
                table: "Semesters",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Programs_ProgramId",
                table: "Semesters",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
