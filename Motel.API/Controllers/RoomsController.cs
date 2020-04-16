using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motel.API.Models;

namespace Motel.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly MotelContext _context;

        public RoomsController(MotelContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult<Room>> GetRooms()
        {
            IQueryable<Room> rooms = _context.Rooms;
            return Ok(await rooms.ToListAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoomById([FromRoute] int id)
        {
            Room room = await _context.Rooms.FindAsync(id);
            return Ok(new { Layout = room.RoomLayout });
        }

    }
}