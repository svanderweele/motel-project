using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Motel.API.Classes;
using Motel.API.Models;

namespace Motel.API.Services
{


    public interface IReservationService
    {
        Task<GetReservationDto> CreateReservation(CreateReservationDto reservationDto);
        Task UpdateReservation(Guid reference, UpdateReservationDto reservationDto);
        Task<List<GetReservationDto>> GetReservations(ReservationQueryParameters reservationQueryParameters);
        Task<GetReservationDto> GetReservation(Guid reference);
        Task<GetReservationDto> DeleteReservation(Guid reference);
    }

    public class ReservationNotFoundException : Exception
    {
        public ReservationNotFoundException(Guid reference) : base($"Reservation with ref {reference} not found.")
        {
        }
    }


    public class ReservationService : IReservationService
    {

        private readonly MotelContext _context;

        public ReservationService(MotelContext context)
        {
            _context = context;
        }

        public async Task<GetReservationDto> CreateReservation(CreateReservationDto reservationDto)
        {
            Reservation reservation = new Reservation
            {
                ArrivalDate = reservationDto.ArrivalDate,
                DepartureDate = reservationDto.DepartureDate,
                NumberOfAdults = reservationDto.NumberOfAdults,
                NumberOfChildren = reservationDto.NumberOfChildren,
                UserId = reservationDto.UserId,
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
            return new GetReservationDto(reservation);
        }

        public async Task<GetReservationDto> DeleteReservation(Guid reference)
        {
            Reservation reservation = await _context.Reservations.FirstOrDefaultAsync(e => e.Ref == reference);
            if (reservation == null)
            {
                throw new ReservationNotFoundException(reference);
            }

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return new GetReservationDto(reservation);
        }

        public async Task<GetReservationDto> GetReservation(Guid reference)
        {

            Reservation reservation = await _context.Reservations.FirstOrDefaultAsync(e => e.Ref == reference);

            if (reservation == null)
            {
                throw new ReservationNotFoundException(reference);
            }

            return new GetReservationDto(reservation);
        }

        public async Task<List<GetReservationDto>> GetReservations(ReservationQueryParameters reservationQueryParameters)
        {
            IQueryable<Reservation> reservations = _context.Reservations;

            if (reservationQueryParameters.DepartureDate.HasValue && reservationQueryParameters.ArrivalDate.HasValue)
            {
                reservations = reservations.Where(e => reservationQueryParameters.ArrivalDate.Value.CompareTo(e.ArrivalDate) != 1 && reservationQueryParameters.DepartureDate.Value.CompareTo(e.DepartureDate) != -1);
            }

            if (string.IsNullOrEmpty(reservationQueryParameters.SortBy) == false)
            {
                if (typeof(Reservation).GetProperty(reservationQueryParameters.SortBy) != null)
                {
                    reservations = reservations.OrderByCustom(reservationQueryParameters.SortBy, reservationQueryParameters.SortOrder);
                }
            }

            if (reservationQueryParameters.ShowDeleted == false)
            {
                reservations = reservations.Where(e => e.DeletedAt.HasValue == false);
            }

            List<GetReservationDto> reservationDtos = new List<GetReservationDto>();

            foreach (Reservation reservation in await reservations.ToListAsync())
            {
                reservationDtos.Add(new GetReservationDto(reservation));
            }

            return reservationDtos;
        }


        public async Task UpdateReservation(Guid reference, UpdateReservationDto reservationDto)
        {

            Reservation reservation = await _context.Reservations.FirstOrDefaultAsync(e => e.Ref == reference);

            if (reservation == null)
            {
                throw new ReservationNotFoundException(reference);
            }

            if (reservationDto.DepartureDate.HasValue)
            {
                reservation.DepartureDate = reservationDto.DepartureDate.Value;
            }

            if (reservationDto.ArrivalDate.HasValue)
            {
                reservation.ArrivalDate = reservationDto.ArrivalDate.Value;
            }


            if (reservationDto.NumberOfAdults != null)
            {
                reservation.NumberOfAdults = reservationDto.NumberOfAdults.Value;
            }


            if (reservationDto.NumberOfChildren != null)
            {
                reservation.NumberOfChildren = reservationDto.NumberOfChildren.Value;
            }



            if (reservationDto.UserId != null)
            {
                reservation.UserId = reservationDto.UserId.Value;
            }


            _context.Update(reservation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}