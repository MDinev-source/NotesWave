namespace NotesWave.Data.Models.Note
{
    using NotesWave.Data.Models.Common;
    using DescModel = NotesWave.Data.Models.Description;
    public class NoteDescription : BaseDeletableModel
    {
        public string NoteID { get; set; }
        public Note Note { get; set; }

        public string DescriptionID { get; set; }
        public DescModel.Description Description { get; set; }
    }
}
