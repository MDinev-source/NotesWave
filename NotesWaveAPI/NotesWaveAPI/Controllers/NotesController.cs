namespace NotesWaveAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using NotesWave.Data.Models.Note;
    using NotesWave.RequestModels.Notes;
    using NotesWave.Services.Contracts;

    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> logger;
        private readonly INotesService notesService;

        public NotesController(ILogger<NotesController> logger, INotesService notesService)
        {
            this.logger = logger;
            this.notesService = notesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var notes = await this.notesService.GetAll();

            return Ok(notes);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNoteRequestModel createNoteRequestModel)
        {
            string noteId = await this.notesService.Create(createNoteRequestModel);

            return Created(nameof(this.Create), noteId);
        }
    }
}
