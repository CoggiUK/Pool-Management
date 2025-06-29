using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Pool_Management.Models;
using Pool_Management.Repositories;

namespace Pool_Management.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly PoolManagementContext _context;

        public AuthController(PoolManagementContext context)
        {
            _context = context;
        }

        //login
        [HttpPost("login")]
        public IActionResult Login( LoginModel model)
        {

            var user = _context.Users
                .FirstOrDefault(u => u.Username == model.Username && u.PasswordHash == model.Password);

            if (user == null)
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }

            return Ok(new { message = "Login successful" });
        }
    }
}
