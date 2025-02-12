namespace NotesWave.RequestModels.Notes
{
    using NotesWave.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    public class CreateNoteRequestModel
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public NoteState State => NoteState.New;
    }
}
