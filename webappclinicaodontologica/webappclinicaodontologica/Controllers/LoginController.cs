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

            // VALIDAR: USUARIO + CONTRASEÑA + ROL + ESTADO
            var empleado = await _context.Empleados
                .Include(e => e.Rol)
                .FirstOrDefaultAsync(e =>
                    e.Usuario == login.Usuario &&
                    e.Contrasena == login.Contrasena &&
                    e.IdRol == login.IdRol &&          // ← VALIDACIÓN CORRECTA DEL ROL
                    e.Estado == "Activo");

            if (empleado == null)
                return Unauthorized("Usuario, contraseña o rol incorrectos");

            // Seleccionar panel correcto según el rol
            string rol = empleado.Rol.NombreRol?.ToLower() ?? "";

            string panelDestino = rol switch
            {
                "recepcionista" => "/views/recepcionista.html",
                "doctor" => "/views/doctor.html",
                "administrador" => "/views/administrador.html",
                _ => "/views/login.html"
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
