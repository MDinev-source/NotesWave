namespace NotesWave.Services.Contracts
{
    using NotesWave.Data.Models.Note;
    using NotesWave.RequestModels.Notes;

    public interface INotesService
    {
        Task<IEnumerable<Note>> GetAll();

        Task<string> Create(CreateNoteRequestModel createNoteRequestModel);
    }
}
