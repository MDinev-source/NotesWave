﻿namespace NotesWave.Services.Contracts
{
    using NotesWave.Data.Models.Description;
    using NotesWave.RequestModels.Descriptions;
    public interface IDescriptionsService
    {
        Task UpdateDescription(UpdateDescriptionRequestModel updateDescriptionRequestModel);

        Task AddDescriptionToNote(string noteId, string text);

        Task RemoveDescriptionFromNote(string descId);
    }
}
