using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notes.Core;
using Notes.DB;

namespace Notes.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> _logger;
        private INotesServices _notesServices;

        public NotesController(ILogger<NotesController> logger, INotesServices notesServices)
        {
            _logger = logger;
            _notesServices = notesServices;
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public IActionResult GetNotes()
        {
            return Ok(_notesServices.GetNotes());
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "GetNote")]
        public IActionResult GetNote(int id)
        {
            return Ok(_notesServices.GetNote(id));
        }

        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public IActionResult CreateNote(Note note)
        {
            var newNote = _notesServices.CreateNote(note);
            return CreatedAtRoute("GetNote", new { newNote.Id }, newNote);
        }

        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            _notesServices.DeleteNote(id);
            return Ok();
        }

        [EnableCors("AnotherPolicy")]
        [HttpPut]
        public IActionResult EditNote([FromBody] Note note)
        {
            _notesServices.EditNote(note);
            return Ok();
        } 
    }
}
