using NotesWave.Data.Models.Common;

namespace NotesWave.Data.Models.Note
{
    public class NoteRels : BaseDeletableModel
    {
        public string NoteID { get; set; }
        public Note Note { get; set; }

        public string NoteRelID { get; set; }
        public Note NoteRel { get; set; }
    }
}
