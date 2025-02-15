namespace NotesWave.Data.Models.Description
{
    using NotesWave.Data.Models.Common;
    using NotesWave.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

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
    }
}
