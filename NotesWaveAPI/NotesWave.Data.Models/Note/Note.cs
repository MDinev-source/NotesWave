namespace NotesWave.Data.Models.Note
{
    using NotesWave.Data.Models.Common;
    using NotesWave.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Note : BaseDeletableModel
    {
        public Note()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Notes = new HashSet<NoteRels>();
            this.NoteDescriptions = new HashSet<NoteDescription>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        [Required]
        public NoteState state { get; set; }

        public virtual ICollection<NoteRels> Notes { get; set; }

        public virtual ICollection<NoteDescription> NoteDescriptions { get; set; }
    }
}
