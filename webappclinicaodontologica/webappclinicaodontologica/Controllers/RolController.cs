using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly MyDbContext _context;

        public RolController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRoles()
        {
            var roles = await _context.Roles.ToListAsync();
            return Ok(roles);
        }
    }
}
