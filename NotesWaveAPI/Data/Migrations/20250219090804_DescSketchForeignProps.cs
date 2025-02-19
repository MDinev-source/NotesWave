using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesWave.Data.Migrations
{
    /// <inheritdoc />
    public partial class DescSketchForeignProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Notes_NoteId",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Notes");

            migrationBuilder.AddColumn<string>(
                name: "NoteId",
                table: "Sketches",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NoteId",
                table: "Descriptions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Descriptions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sketches_NoteId",
                table: "Sketches",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Notes_NoteId",
                table: "Descriptions",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sketches_Notes_NoteId",
                table: "Sketches",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Notes_NoteId",
                table: "Descriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sketches_Notes_NoteId",
                table: "Sketches");

            migrationBuilder.DropIndex(
                name: "IX_Sketches_NoteId",
                table: "Sketches");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Sketches");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Descriptions");

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "NoteId",
                table: "Descriptions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Notes_NoteId",
                table: "Descriptions",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id");
        }
    }
}
