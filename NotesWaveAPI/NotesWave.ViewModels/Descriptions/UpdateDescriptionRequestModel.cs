namespace NotesWave.RequestModels.Descriptions
{
    using NotesWave.Data.Models.Enums;
    using System.Text.Json.Serialization;
    using System.ComponentModel.DataAnnotations;

    public class UpdateDescriptionRequestModel
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DescriptionType Type { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Text { get; set; }
    }
}
