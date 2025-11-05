using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Models;
using webappclinicaodontologica.Data;

namespace webappclinicaodontologica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly MyDbContext _context;

        public LoginController(MyDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u =>
                    u.usuario_nombre == model.usuario_nombre &&
                    u.contrasena == model.contrasena &&
                    u.rol_id == model.rol_id);

            if (usuario == null)
                return Unauthorized("Credenciales inválidas");

            return Ok(usuario);
        }

    }
}
