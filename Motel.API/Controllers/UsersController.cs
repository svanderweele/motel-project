using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Motel.API.Classes;
using Motel.API.Models;

namespace Motel.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly MotelContext _context;

        public UsersController(MotelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<bool>> GetUsers()
        {
            string comparePass = "password";

            User user = await _context.Users.FindAsync(1);

            bool validPass = MyPasswordHasher.VerifyPassword(comparePass, user.PasswordHash, user.PasswordSalt);

            return Ok(new { IsValid = validPass });
        }
    }
}