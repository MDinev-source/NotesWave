namespace NotesWave.Services
{
    using NoteWaves.Data;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using NotesWave.Data.Models.Note;
    using NotesWave.Services.Contracts;
    using Microsoft.EntityFrameworkCore;
    using NotesWave.RequestModels.Notes;

    public class NotesService : INotesService
    {
        private readonly NotesWaveDBContext data;

        public NotesService(NotesWaveDBContext data)
        {
            this.data = data;
        }

        public async Task<string> Create(CreateNoteRequestModel createNoteRequestModel)
        {
            Note createNote = new Note
            {
                Title = createNoteRequestModel.Title
            };

            this.data.Notes.Add(createNote);

            await this.data.SaveChangesAsync();

            return createNote.Id;
        }

        public async Task<IEnumerable<Note>> GetAll()
        {
            List<Note> notes = await this.data
                .Notes
                .ToListAsync();

            return notes;
        }
    }
}
