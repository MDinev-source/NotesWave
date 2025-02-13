using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesWave.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDescRelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NoteDescriptions");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Descriptions");

            migrationBuilder.AddColumn<string>(
                name: "NoteId",
                table: "Descriptions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_NoteId",
                table: "Descriptions",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Notes_NoteId",
                table: "Descriptions",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Notes_NoteId",
                table: "Descriptions");

            migrationBuilder.DropIndex(
                name: "IX_Descriptions_NoteId",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Descriptions");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Descriptions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Descriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NoteDescriptions",
                columns: table => new
                {
                    NoteID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DescriptionID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteDescriptions", x => new { x.NoteID, x.DescriptionID });
                    table.ForeignKey(
                        name: "FK_NoteDescriptions_Descriptions_DescriptionID",
                        column: x => x.DescriptionID,
                        principalTable: "Descriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteDescriptions_Notes_NoteID",
                        column: x => x.NoteID,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NoteDescriptions_DescriptionID",
                table: "NoteDescriptions",
                column: "DescriptionID");
        }
    }
}
