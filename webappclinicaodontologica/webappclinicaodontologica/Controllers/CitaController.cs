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
        private readonly TimeSpan duracion = TimeSpan.FromMinutes(30);

        public CitaController(MyDbContext context)
        {
            _context = context;
        }

        // LISTAR CITAS
        [HttpGet]
        public async Task<IEnumerable<object>> GetCitas()
        {
            return await _context.Citas
                .Join(_context.Pacientes,
                    c => c.IdPaciente,
                    p => p.IdPaciente,
                    (c, p) => new {
                        c.IdCita,
                        c.IdPaciente,
                        Paciente = p.Nombre,
                        c.Doctor,
                        c.Fecha,
                        Hora = c.Hora.ToString(@"hh\:mm"),
                        c.Motivo,
                        c.Estado
                    })
                .ToListAsync();
        }

        // CITA POR ID
        [HttpGet("{id}")]
        public async Task<object> GetCita(int id)
        {
            return await _context.Citas.FindAsync(id);
        }

        // HORAS DISPONIBLES
        [HttpGet("horas-disponibles/{fecha}")]
        public async Task<IEnumerable<string>> GetHorasDisponibles(DateTime fecha)
        {
            List<TimeSpan> horarios = new();

            for (int h = 8; h <= 17; h++)
            {
                horarios.Add(new TimeSpan(h, 0, 0));
                horarios.Add(new TimeSpan(h, 30, 0));
            }

            var citas = await _context.Citas
                .Where(c => c.Fecha == fecha)
                .ToListAsync();

            List<string> libres = new();

            foreach (var hora in horarios)
            {
                bool ocupado = citas.Any(c =>
                    (hora >= c.Hora && hora < c.Hora.Add(duracion))
                );

                if (!ocupado)
                    libres.Add(hora.ToString(@"hh\:mm"));
            }

            return libres;
        }

        // CREAR
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Cita cita)
        {
            TimeSpan horaFin = cita.Hora.Add(duracion);

            bool choque = await _context.Citas.AnyAsync(c =>
                c.Fecha == cita.Fecha &&
                (
                    (cita.Hora >= c.Hora && cita.Hora < c.Hora.Add(duracion)) ||
                    (horaFin > c.Hora && horaFin <= c.Hora.Add(duracion)) ||
                    (c.Hora >= cita.Hora && c.Hora < horaFin)
                )
            );

            if (choque)
                return BadRequest(new { mensaje = "Este horario ya está ocupado." });

            _context.Citas.Add(cita);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Cita creada exitosamente." });
        }

        // ACTUALIZAR
        [HttpPut("{id}")]
        public async Task<IActionResult> Editar(int id, [FromBody] Cita cita)
        {
            if (id != cita.IdCita)
                return BadRequest();

            _context.Entry(cita).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Cita actualizada." });
        }

        // ELIMINAR
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var cita = await _context.Citas.FindAsync(id);
            if (cita == null)
                return NotFound();

            _context.Citas.Remove(cita);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Cita eliminada." });
        }
    }
}
