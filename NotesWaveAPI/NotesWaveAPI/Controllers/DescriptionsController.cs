namespace NotesWaveAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using NotesWave.Services.Contracts;
    using NotesWave.RequestModels.Descriptions;

    [Route("api/[controller]")]
    [ApiController]
    public class DescriptionsController : ControllerBase
    {
        private readonly IDescriptionsService descriptionsService;

        public DescriptionsController(IDescriptionsService descriptionsService)
        {
            this.descriptionsService = descriptionsService;
        }

        [HttpPut("{descriptionId}")]
        public async Task<IActionResult> Update(UpdateDescriptionRequestModel updateDescriptionRequestModel, string descriptionId)
        {
            await descriptionsService.UpdateDescription(updateDescriptionRequestModel, descriptionId);

            return Ok();
        }

        [HttpPost("{noteId}")]
        public async Task<IActionResult> AddDescriptionToNote(string noteId, [FromBody] string text)
        {
            await descriptionsService.AddDescriptionToNote(noteId, text);

            return Ok();
        }

        [HttpDelete("{descriptionId}")]
        public async Task<IActionResult> RemoveDescriptionFromNote (string descriptionId)
        {
            await descriptionsService.RemoveDescriptionFromNote(descriptionId);

            return Ok();
        }
    }
}
