namespace NotesWave.Services.Contracts
{
    using NotesWave.RequestModels.Descriptions;
    public interface IDescriptionsService
    {
        Task<string> UpdateDescription(UpdateDescriptionRequestModel updateDescriptionRequestModel, string id);
    }
}
