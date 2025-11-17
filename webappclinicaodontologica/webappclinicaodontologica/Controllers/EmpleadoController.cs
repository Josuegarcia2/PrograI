using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        // GET: api/Empleado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleados()
        {
            return await _context.Empleados
                .OrderBy(e => e.IdEmpleado)
                .ToListAsync();
        }

        // GET: api/Empleado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(int id)
        {
            var emp = await _context.Empleados.FindAsync(id);

            if (emp == null)
                return NotFound();

            return emp;
        }

        // POST: api/Empleado
        [HttpPost]
        public async Task<IActionResult> CrearEmpleado([FromBody] Empleado empleado)
        {
            if (empleado == null)
                return BadRequest("Datos inválidos");

            bool existe = await _context.Empleados
                            .AnyAsync(e => e.Usuario == empleado.Usuario);

            if (existe)
                return BadRequest("Usuario duplicado");

            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();

            return Ok(empleado);
        }

        // PUT: api/Empleado/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditarEmpleado(int id, [FromBody] Empleado empleado)
        {
            if (id != empleado.IdEmpleado)
                return BadRequest("ID no coincide");

            // Validar duplicado solo si OTRO empleado usa ese usuario
            bool existeOtro = await _context.Empleados
                                .AnyAsync(e => e.Usuario == empleado.Usuario &&
                                               e.IdEmpleado != id);

            if (existeOtro)
                return BadRequest("Usuario duplicado");

            _context.Empleados.Update(empleado);
            await _context.SaveChangesAsync();

            return Ok(empleado);
        }

        // DELETE: api/Empleado/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmpleado(int id)
        {
            var emp = await _context.Empleados.FindAsync(id);
            if (emp == null)
                return NotFound();

            _context.Empleados.Remove(emp);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Empleado eliminado" });
        }
    }
}
