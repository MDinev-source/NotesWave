namespace NoteWaves.Data
{
    using NotesWave.Data.Models.Note;
    using NotesWave.Data.Models.Sketch;
    using Microsoft.EntityFrameworkCore;
    using NotesWave.Data.Models.Description;
    using Microsoft.Extensions.Configuration;

    public class NotesWaveDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        protected NotesWaveDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public NotesWaveDBContext(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteDescription> NoteDescriptions { get; set; }
        public DbSet<NoteRels> NoteRels { get; set; }
        public DbSet<NoteSketch> NoteSketches { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Sketch> Sketches { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<NoteDescription>().HasKey(e => new { e.NoteID, e.DescriptionID });

            builder.Entity<NoteRels>().HasKey(e => new { e.NoteID, e.NoteRelID });

            builder.Entity<NoteSketch>().HasKey(e => new { e.NoteID, e.SketchID });
        }
    }
}
