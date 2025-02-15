namespace NotesWave.Services
{
    using NoteWaves.Data;
    using NotesWave.Services.Contracts;
    using Microsoft.EntityFrameworkCore;
    using NotesWave.Data.Models.Description;
    using NotesWave.RequestModels.Descriptions;

    public class DescriptionsService : IDescriptionsService
    {
        private readonly NotesWaveDBContext notesWaveDBContext;
        public DescriptionsService(NotesWaveDBContext notesWaveDBContext) 
        {
            this.notesWaveDBContext = notesWaveDBContext; 
        }
        public async Task<string> UpdateDescription(UpdateDescriptionRequestModel createDescriptionRequestModel, string id)
        {
            Description? descriptionUpdate = await notesWaveDBContext
                .Descriptions
                .FirstOrDefaultAsync(d => d.Id == id);

            if (descriptionUpdate == null)
            {
                return "";
            }

            return descriptionUpdate.Id;
        }
    }
}
