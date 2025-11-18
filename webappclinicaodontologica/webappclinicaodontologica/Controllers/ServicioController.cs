using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ServicioController(MyDbContext context)
        {
            _context = context;
        }

        // ===============================
        //  GET: TODOS LOS SERVICIOS
        // ===============================
        [HttpGet]
        public async Task<IActionResult> GetServicios()
        {
            var lista = await _context.Servicios
                .Select(s => new
                {
                    s.IdServicio,
                    s.NombreServicio,
                    s.Precio,
                    s.Descripcion,
                    s.Estado,
                    s.FotoUrl,

                    Doctor1Id = s.Doctor1Id,
                    Doctor2Id = s.Doctor2Id,

                    Doctor1Nombre = s.Doctor1 != null ? s.Doctor1.Nombre + " " + s.Doctor1.Apellido : null,
                    Doctor2Nombre = s.Doctor2 != null ? s.Doctor2.Nombre + " " + s.Doctor2.Apellido : null
                })
                .ToListAsync();

            return Ok(lista);
        }

        // ===============================
        //  GET: SERVICIO POR ID
        // ===============================
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServicio(int id)
        {
            var s = await _context.Servicios
                .Select(x => new
                {
                    x.IdServicio,
                    x.NombreServicio,
                    x.Precio,
                    x.Descripcion,
                    x.Estado,
                    x.FotoUrl,
                    x.Doctor1Id,
                    x.Doctor2Id
                })
                .FirstOrDefaultAsync(x => x.IdServicio == id);

            if (s == null)
                return NotFound();

            return Ok(s);
        }

        // ===============================
        //  POST: CREAR SERVICIO
        // ===============================
        [HttpPost]
        public async Task<IActionResult> CrearServicio([FromBody] Servicio servicio)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Asegurar valores
            servicio.Estado ??= "Activo";

            _context.Servicios.Add(servicio);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Servicio creado con éxito" });
        }

        // ===============================
        //  PUT: ACTUALIZAR SERVICIO
        // ===============================
        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] Servicio servicio)
        {
            var db = await _context.Servicios.FindAsync(id);
            if (db == null)
                return NotFound();

            db.NombreServicio = servicio.NombreServicio;
            db.Precio = servicio.Precio;
            db.Descripcion = servicio.Descripcion;
            db.Estado = servicio.Estado;
            db.Doctor1Id = servicio.Doctor1Id;
            db.Doctor2Id = servicio.Doctor2Id;

            if (!string.IsNullOrEmpty(servicio.FotoUrl))
                db.FotoUrl = servicio.FotoUrl;

            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Servicio actualizado" });
        }

        // ===============================
        //  DELETE
        // ===============================
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var servicio = await _context.Servicios.FindAsync(id);

            if (servicio == null)
                return NotFound();

            _context.Servicios.Remove(servicio);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Servicio eliminado" });
        }

        // ===============================
        //  SUBIR FOTO
        // ===============================
        [HttpPost("subir-foto")]
        public async Task<IActionResult> SubirFoto(IFormFile archivo)
        {
            if (archivo == null || archivo.Length == 0)
                return BadRequest("Archivo no válido");

            var carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/servicios");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            var nombre = Guid.NewGuid().ToString() + Path.GetExtension(archivo.FileName);

            var ruta = Path.Combine(carpeta, nombre);

            using (var stream = new FileStream(ruta, FileMode.Create))
            {
                await archivo.CopyToAsync(stream);
            }

            return Ok(new { url = $"/img/servicios/{nombre}" });
        }

        // ===============================
        //  GET DOCTORES
        // ===============================
        [HttpGet("doctores")]
        public async Task<IActionResult> GetDoctores()
        {
            var doctores = await _context.Empleados
                .Where(e => e.IdRol == 2)
                .Select(e => new
                {
                    e.IdEmpleado,
                    Nombre = e.Nombre + " " + e.Apellido
                })
                .ToListAsync();

            return Ok(doctores);
        }
    }
}
