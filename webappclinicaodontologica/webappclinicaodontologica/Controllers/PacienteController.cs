using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PacienteController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetPacientes()
        {
            return await _context.Pacientes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetPaciente(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null) return NotFound();
            return Ok(paciente);
        }

        [HttpPost]
        public async Task<ActionResult<Paciente>> CrearPaciente(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
            return Ok(paciente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarPaciente(int id, Paciente paciente)
        {
            if (id != paciente.IdPaciente) return BadRequest();
            _context.Entry(paciente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPaciente(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null) return NotFound();
            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
