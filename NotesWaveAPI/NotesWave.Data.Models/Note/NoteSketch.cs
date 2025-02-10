namespace NotesWave.Data.Models.Note
{
    using NotesWave.Data.Models.Common;
    using SketchModel = NotesWave.Data.Models.Sketch;
    public class NoteSketch : BaseDeletableModel
    {
        public string NoteID { get; set; }
        public Note Note { get; set; }

        public string SketchID { get; set; }
        public SketchModel.Sketch Sketch { get; set; }
    }
}
