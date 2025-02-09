namespace NotesWave.Data.Models.Description
{
    using NotesWave.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Description
    {
        public Description()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [MaxLength(200)]
        public string? Text { get; set; }

        [Required]
        public DescriptionType type { get; set; }
    }
}
