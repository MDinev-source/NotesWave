namespace NotesWaveAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
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
            var notes = await notesService.GetAll();

            return Ok(notes);
        }
    }
}
