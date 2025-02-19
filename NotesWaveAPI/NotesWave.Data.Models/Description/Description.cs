namespace NotesWave.Data.Models.Description
{
    using NotesWave.Data.Models.Enums;
    using NotesWave.Data.Models.Common;
    using System.Text.Json.Serialization;
    using System.ComponentModel.DataAnnotations;
    using NoteModel = NotesWave.Data.Models.Note;

    public class Description : BaseDeletableModel
    {
        public Description()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [MaxLength(200)]
        public string Text { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DescriptionType Type => DescriptionType.Title;

        public string NoteId { get; set; }
        public NoteModel.Note Note { get; set; }
    }
}
