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
            this.RelatedNotes = new HashSet<NoteRels>();
            this.NoteDescriptions = new HashSet<NoteDescription>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public NoteState state { get; set; }

        public virtual ICollection<NoteRels> RelatedNotes { get; set; }

        public virtual ICollection<NoteDescription> NoteDescriptions { get; set; }
    }
}
