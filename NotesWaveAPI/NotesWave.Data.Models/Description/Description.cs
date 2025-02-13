namespace NotesWave.Data.Models.Description
{
    using NotesWave.Data.Models.Common;
    using NotesWave.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Description : BaseDeletableModel
    {
        public Description()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [MaxLength(200)]
        public string? Text => "";

        [Required]
        public DescriptionType type => DescriptionType.Title;
    }
}
