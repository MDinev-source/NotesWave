namespace NotesWave.Data.Models.Sketch
{
    using NotesWave.Data.Models.Common;
    using System.ComponentModel.DataAnnotations;
    using NoteModel = NotesWave.Data.Models.Note;

    public class Sketch : BaseDeletableModel
    {
        public Sketch ()
        {
            this.ID = Guid.NewGuid().ToString();
        }

        [Key]
        public string ID { get; set; }

        public string Coordinates { get; set; }

        public string NoteId { get; set; }
        public NoteModel.Note Note { get; set; }
    }
}
