﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteWaves.Data;

#nullable disable

namespace NotesWave.Data.Migrations
{
    [DbContext(typeof(NotesWaveDBContext))]
    [Migration("20250211163823_UpdateNoteModel")]
    partial class UpdateNoteModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NotesWave.Data.Models.Description.Description", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.Note", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.NoteDescription", b =>
                {
                    b.Property<string>("NoteID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DescriptionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("NoteID", "DescriptionID");

                    b.HasIndex("DescriptionID");

                    b.ToTable("NoteDescriptions");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.NoteRels", b =>
                {
                    b.Property<string>("NoteID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NoteRelID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("NoteID", "NoteRelID");

                    b.HasIndex("NoteRelID");

                    b.ToTable("NoteRels");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.NoteSketch", b =>
                {
                    b.Property<string>("NoteID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SketchID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("NoteID", "SketchID");

                    b.HasIndex("SketchID");

                    b.ToTable("NoteSketches");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Sketch.Sketch", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Coordinates")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Sketches");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.NoteDescription", b =>
                {
                    b.HasOne("NotesWave.Data.Models.Description.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NotesWave.Data.Models.Note.Note", "Note")
                        .WithMany("NoteDescriptions")
                        .HasForeignKey("NoteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Description");

                    b.Navigation("Note");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.NoteRels", b =>
                {
                    b.HasOne("NotesWave.Data.Models.Note.Note", "Note")
                        .WithMany("RelatedNotes")
                        .HasForeignKey("NoteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NotesWave.Data.Models.Note.Note", "NoteRel")
                        .WithMany()
                        .HasForeignKey("NoteRelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Note");

                    b.Navigation("NoteRel");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.NoteSketch", b =>
                {
                    b.HasOne("NotesWave.Data.Models.Note.Note", "Note")
                        .WithMany()
                        .HasForeignKey("NoteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NotesWave.Data.Models.Sketch.Sketch", "Sketch")
                        .WithMany()
                        .HasForeignKey("SketchID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Note");

                    b.Navigation("Sketch");
                });

            modelBuilder.Entity("NotesWave.Data.Models.Note.Note", b =>
                {
                    b.Navigation("NoteDescriptions");

                    b.Navigation("RelatedNotes");
                });
#pragma warning restore 612, 618
        }
    }
}
