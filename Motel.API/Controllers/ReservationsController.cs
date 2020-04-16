using System.Linq;
using System.Threading.Tasks;
using Motel.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motel.API.Classes;
using Motel.API.Models;
using System;
using Motel.API.Services;
using System.Collections.Generic;

namespace Motel.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly MotelContext _context;
        private readonly IReservationService _reservationService;

        public ReservationsController(MotelContext context, IReservationService reservationService)
        {
            _context = context;
            _reservationService = reservationService;
        }


        [HttpGet]
        public async Task<ActionResult<GetReservationDto>> GetReservations([FromQuery] ReservationQueryParameters reservationQueryParameters)
        {
            List<GetReservationDto> reservations = await _reservationService.GetReservations(reservationQueryParameters);
            return Ok(reservations);
        }


        [HttpGet("{reference}")]
        public async Task<ActionResult<Reservation>> GetReservationByRef([FromRoute] Guid reference)
        {
            GetReservationDto reservationDto = null;
            try
            {
                reservationDto = await _reservationService.GetReservation(reference);
            }
            catch (Exception e)
            {
                if (e is ReservationNotFoundException)
                {
                    return NotFound(e.Message);
                }
            }

            return Ok(reservationDto);
        }



        [HttpPost]
        public async Task<ActionResult<GetReservationDto>> PostReservation([FromBody] CreateReservationDto reservationDto)
        {
            GetReservationDto getReservationDto = await _reservationService.CreateReservation(reservationDto);
            return CreatedAtAction("GetReservationByRef", new { reference = getReservationDto.Ref }, getReservationDto);
        }


        [HttpPut("{reference}")]
        public async Task<IActionResult> PutReservation([FromRoute] Guid reference, [FromBody] UpdateReservationDto reservationDto)
        {
            try
            {
                await _reservationService.UpdateReservation(reference, reservationDto);
            }
            catch (Exception e)
            {

                if (e is ReservationNotFoundException)
                {
                    return NotFound(e.Message);
                }

                throw e;
            }


            return NoContent();
        }


        [HttpDelete("{reference}")]
        public async Task<ActionResult<GetReservationDto>> DeleteReservation([FromRoute] Guid reference)
        {
            GetReservationDto getReservationDto = null;
            try
            {
                getReservationDto = await _reservationService.DeleteReservation(reference);
            }
            catch (Exception e)
            {
                if (e is ReservationNotFoundException)
                {
                    return NotFound(e.Message);
                }

                throw e;
            }

            return getReservationDto;
        }
    }
}