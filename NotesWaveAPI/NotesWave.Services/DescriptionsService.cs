namespace NotesWave.Services
{
    using NoteWaves.Data;
    using NotesWave.Data.Models.Note;
    using NotesWave.Data.Models.Enums;
    using NotesWave.Services.Contracts;
    using NotesWave.Data.Models.Description;
    using NotesWave.RequestModels.Descriptions;

    public class DescriptionsService : IDescriptionsService
    {
        private readonly NotesWaveDBContext notesWaveDBContext;
        public DescriptionsService(NotesWaveDBContext notesWaveDBContext) 
        {
            this.notesWaveDBContext = notesWaveDBContext; 
        }

        public async Task AddDescriptionToNote(string noteId, string text)
        {
            Note? note = await notesWaveDBContext
                .Notes
                .FindAsync(noteId);

            if (note != null)
            {
                Description newDescription = new Description
                {
                    Text = text,
                    Type = DescriptionType.Title
                };

                note.Descriptions.Add(newDescription);

                await notesWaveDBContext.SaveChangesAsync();
            }
        }

        public async Task RemoveDescriptionFromNote(string descId)
        {
            Description? description = await notesWaveDBContext
              .Descriptions
              .FindAsync(descId);

            if (description != null)
            {
                notesWaveDBContext
                    .Descriptions
                    .Remove(description);

                await notesWaveDBContext.SaveChangesAsync();
            }
        }

        public async Task UpdateDescription(UpdateDescriptionRequestModel createDescriptionRequestModel)
        {
            Description? descriptionUpdate = await notesWaveDBContext
                .Descriptions
                .FindAsync(createDescriptionRequestModel.Id);

            if (descriptionUpdate != null && createDescriptionRequestModel.Text != null)
            {
                descriptionUpdate.Text = createDescriptionRequestModel.Text;

                if (createDescriptionRequestModel.Type != descriptionUpdate.Type)
                {
                    descriptionUpdate.Type = createDescriptionRequestModel.Type;
                }

                await notesWaveDBContext.SaveChangesAsync();
            }

        }
    }
}
