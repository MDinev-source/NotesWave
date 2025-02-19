namespace NotesWave.Data.Models.Note
{
    using NotesWave.Data.Models.Enums;
    using NotesWave.Data.Models.Common;
    using System.ComponentModel.DataAnnotations;
    using DescModel = NotesWave.Data.Models.Description;
    using System.Text.Json.Serialization;

    public class Note : BaseDeletableModel
    {
        public Note()
        {
            this.Id = Guid.NewGuid().ToString();
            this.RelatedNotes = new HashSet<NoteRels>();
            this.Descriptions = new HashSet<DescModel.Description>();
            this.NoteSketches = new HashSet<NoteSketch>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public NoteState State { get; set; }

        public virtual ICollection<NoteRels> RelatedNotes { get; set; }

        public virtual ICollection<DescModel.Description> Descriptions { get; set; }

        public virtual ICollection<NoteSketch> NoteSketches { get; set; }
    }
}
