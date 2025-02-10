namespace NotesWave.Services
{
    using NoteWaves.Data;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using NotesWave.Data.Models.Note;
    using NotesWave.Services.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class NotesService : INotesService
    {
        private readonly NotesWaveDBContext data;

        public NotesService(NotesWaveDBContext data)
        {
            this.data = data;
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
