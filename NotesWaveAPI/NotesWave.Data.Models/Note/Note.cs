namespace NotesWave.Data.Models.Note
{
    using System.ComponentModel.DataAnnotations;
    public class Note
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

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }

        public virtual ICollection<NoteRels> Notes { get; set; }

        public virtual ICollection<NoteDescription> NoteDescriptions { get; set; }
    }
}
