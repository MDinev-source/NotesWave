namespace NotesWave.Data.Models.Common
{
    public class BaseDeletableModel : BaseModel
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
