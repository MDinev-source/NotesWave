using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotesWave.Data.Models.Note;
using NotesWave.Services.Contracts;

namespace NotesWaveAPI.Controllers
{
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
