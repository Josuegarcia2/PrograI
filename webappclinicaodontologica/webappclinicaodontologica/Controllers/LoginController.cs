using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data;
using webappclinicaodontologica.Models.ViewModels;

namespace webappclinicaodontologica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly MyDbContext _context;

        public LoginController(MyDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel login)
        {
            var empleado = await _context.Empleados
                .Include(e => e.Rol)
                .FirstOrDefaultAsync(e =>
                    e.Usuario == login.Usuario &&
                    e.Contrasena == login.Contrasena);

            if (empleado == null)
                return Unauthorized("Usuario o contraseña incorrectos");

            var panel = empleado.Rol.NombreRol.ToLower() switch
            {
                "recepcionista" => "PanelRecepcionista",
                "doctor" => "PanelDoctor",
                _ => "PanelGeneral"
            };

            return Ok(new
            {
                mensaje = "Login exitoso",
                nombre = empleado.Nombre,
                rol = empleado.Rol.NombreRol,
                panelDestino = empleado.Rol.NombreRol switch
                {
                    "Recepcionista" => "PanelRecepcionista",
                    "Doctor" => "PanelDoctor",
                    _ => "PanelGeneral"
                }
            });

        }
    }
}
