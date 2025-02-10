namespace NotesWave.Services.Contracts
{
    using NotesWave.Data.Models.Note;
    public interface INotesService
    {
        Task<IEnumerable<Note>> GetAll();
    }
}
