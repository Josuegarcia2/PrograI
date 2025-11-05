using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data;
using webappclinicaodontologica.Models;

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
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u =>
                    u.usuario_nombre == login.nombre &&
                    u.contrasena == login.contrasena);

            if (usuario == null)
                return Unauthorized("Credenciales incorrectas");

            return Ok(usuario);
        }
    }
}
