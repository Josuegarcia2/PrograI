using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CitaController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Cita
        [HttpGet]
        public async Task<IActionResult> GetCitas()
        {
            var citas = await _context.Citas
                .Include(c => c.Paciente)
                .Include(c => c.Doctor)
                .ToListAsync();

            return Ok(citas);
        }

        // POST: api/Cita
        [HttpPost]
        public async Task<ActionResult<Cita>> CrearCita([FromBody] Cita cita)
        {
            if (cita == null)
                return BadRequest("Datos inválidos");

            _context.Citas.Add(cita);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Cita guardada correctamente" });
        }


        // GET: api/Cita/Doctores
        [HttpGet("Doctores")]
        public async Task<IActionResult> GetDoctores()
        {
            var doctores = await _context.Doctores
                .Where(d => d.Estado == true)
                .ToListAsync();

            return Ok(doctores);
        }

        // GET: api/Cita/Pacientes
        [HttpGet("Pacientes")]
        public async Task<IActionResult> GetPacientes()
        {
            var pacientes = await _context.Pacientes
                .Where(p => p.Estado == true)
                .ToListAsync();

            return Ok(pacientes);
        }

        // DELETE: api/Cita/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Cancelar(int id)
        {
            var cita = await _context.Citas.FindAsync(id);

            if (cita == null)
                return NotFound();

            cita.Estado = "Cancelada";
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Cita cancelada" });
        }

        // PUT: api/Cita/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Editar(int id, [FromBody] Cita datos)
        {
            var cita = await _context.Citas.FindAsync(id);

            if (cita == null)
                return NotFound();

            cita.Fecha = datos.Fecha;
            cita.Hora = datos.Hora;
            cita.Motivo = datos.Motivo;

            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Cita actualizada" });
        }

    }
}
