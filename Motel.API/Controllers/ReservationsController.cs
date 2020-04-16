using System.Linq;
using System.Threading.Tasks;
using Motel.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motel.API.Classes;
using Motel.API.Models;
using System;

namespace Motel.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly MotelContext _context;

        public ReservationsController(MotelContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<Reservation>> GetReservations([FromQuery] ReservationQueryParameters reservationQueryParameters)
        {
            IQueryable<Reservation> reservations = _context.Reservations;

            if (reservationQueryParameters.DepartureDate != null && reservationQueryParameters.ArrivalDate != null)
            {

                foreach (var res in reservations)
                {
                    var a = res.ArrivalDate.CompareTo(reservationQueryParameters.ArrivalDate);
                    var b = res.DepartureDate.CompareTo(reservationQueryParameters.DepartureDate);
                }

                reservations = reservations.Where(e => e.ArrivalDate.CompareTo(reservationQueryParameters.ArrivalDate) != -1 && e.DepartureDate.CompareTo(reservationQueryParameters.DepartureDate) != 1);
            }

            if (string.IsNullOrEmpty(reservationQueryParameters.SortBy) == false)
            {
                if (typeof(Reservation).GetProperty(reservationQueryParameters.SortBy) != null)
                {
                    reservations = reservations.OrderByCustom(reservationQueryParameters.SortBy, reservationQueryParameters.SortOrder);
                }
            }

            return Ok(await reservations.ToListAsync());
        }


        [HttpGet("{reference}")]
        public async Task<ActionResult<Reservation>> GetReservationByRef([FromRoute] Guid reference)
        {
            Reservation reservation = await _context.Reservations.FirstOrDefaultAsync(e => e.Ref == reference);

            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                ArrivalDate = reservation.ArrivalDate,
                DepartureDate = reservation.DepartureDate,
                NumberOfChildren = reservation.NumberOfChildren,
                NumberOfAdults = reservation.NumberOfAdults,
                Ref = reservation.Ref,
                User = new
                {
                    Ref = reservation.User.Ref,
                    Name = reservation.User.Name,
                    Email = reservation.User.Email
                }
            });
        }



        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation([FromBody] Reservation reservation)
        {
            // reservation.Ref = Guid.NewGuid();
            // _context.Entry(reservation).Property(x => x.Ref).IsModified = true;
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();


            return CreatedAtAction("GetReservationByRef", new { reference = reservation.Ref }, reservation);
        }
    }
}