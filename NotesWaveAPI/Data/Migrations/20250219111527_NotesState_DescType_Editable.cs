using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesWave.Data.Migrations
{
    /// <inheritdoc />
    public partial class NotesState_DescType_Editable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Descriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Descriptions");
        }
    }
}
