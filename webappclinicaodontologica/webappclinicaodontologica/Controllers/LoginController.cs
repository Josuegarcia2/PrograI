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
            if (string.IsNullOrEmpty(login.Usuario) || string.IsNullOrEmpty(login.Contrasena))
                return BadRequest("Usuario o contraseña vacíos");

            // Buscar empleado con su rol
            var empleado = await _context.Empleados
                .Include(e => e.Rol)
                .FirstOrDefaultAsync(e =>
                    e.Usuario == login.Usuario &&
                    e.Contrasena == login.Contrasena &&
                    e.Estado == "Activo");

            if (empleado == null)
                return Unauthorized("Usuario o contraseña incorrectos");

            // Determinar el panel de destino según el rol
            string rol = empleado.Rol.NombreRol?.ToLower() ?? "";
            string panelDestino = rol switch
            {
                "recepcionista" => "PanelRecepcionista",
                "doctor" => "PanelDoctor",
                "administrador" => "PanelAdministrador",
                _ => "PanelGeneral"
            };

            return Ok(new
            {
                mensaje = "Login exitoso",
                nombre = empleado.Nombre + " " + empleado.Apellido,
                rol = empleado.Rol.NombreRol,
                panelDestino
            });
        }
    }
}

