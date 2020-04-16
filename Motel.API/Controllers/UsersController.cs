using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        [HttpGet("{reference}")]
        public async Task<ActionResult<bool>> GetUser([FromRoute] Guid reference)
        {
            User user = await _context.Users.FirstOrDefaultAsync(e => e.Ref == reference);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                Ref = user.Ref,
                Name = user.Name,
                Email = user.Email,
            });
        }

        [HttpPost]
        public async Task<ActionResult<bool>> PostUser([FromBody] User user)
        {
            if (await _context.Users.AnyAsync(e => e.Email == user.Email))
            {
                return Conflict();
            }

            byte[] passwordHash, passwordSalt;
            MyPasswordHasher.CreatePasswordHash(user.PasswordPlain, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            // user.Ref = Guid.NewGuid();
            // _context.Entry(user).Property(e => e.Ref).IsModified = true;
            _context.Entry(user).Property(e => e.PasswordHash).IsModified = true;
            _context.Entry(user).Property(e => e.PasswordSalt).IsModified = true;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetUser", new { reference = user.Ref }, user);
        }

        [HttpDelete("{reference}")]
        public async Task<ActionResult<User>> DeleteUser([FromRoute] Guid reference)
        {
            User user = await _context.Users.FirstOrDefaultAsync(e => e.Ref == reference);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}