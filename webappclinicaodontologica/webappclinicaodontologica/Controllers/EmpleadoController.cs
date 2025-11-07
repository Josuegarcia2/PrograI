using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly MyDbContext _context;

        public EmpleadoController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleados()
        {
            return await _context.Empleados.Include(e => e.Rol).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null) return NotFound();
            return Ok(empleado);
        }

        [HttpPost]
        public async Task<ActionResult<Empleado>> CrearEmpleado(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
            return Ok(empleado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarEmpleado(int id, Empleado empleado)
        {
            if (id != empleado.IdEmpleado) return BadRequest();
            _context.Entry(empleado).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarEmpleado(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null) return NotFound();
            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
