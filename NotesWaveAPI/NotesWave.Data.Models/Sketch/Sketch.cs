namespace NotesWave.Data.Models.Sketch
{
    using System.ComponentModel.DataAnnotations;
    using NotesWave.Data.Models.Common;

    public class Sketch : BaseDeletableModel
    {
        public Sketch ()
        {
            this.ID = Guid.NewGuid().ToString();
        }

        [Key]
        public string ID { get; set; }

        public string Coordinates { get; set; }
    }
}
