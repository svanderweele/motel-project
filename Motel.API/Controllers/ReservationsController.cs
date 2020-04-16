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

                foreach(var res in reservations){
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
    }
}