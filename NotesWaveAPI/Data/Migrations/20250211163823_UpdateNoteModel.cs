using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesWave.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNoteModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Notes",
                newName: "State");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Notes",
                newName: "state");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Notes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
