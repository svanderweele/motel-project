using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Motel.API.Models
{
    public class CreateReservationDto
    {
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public int UserId { get; set; }
    }

    public class UpdateReservationDto
    {
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? NumberOfAdults { get; set; }
        public int? NumberOfChildren { get; set; }
        public int? UserId { get; set; }

    }


    public class GetReservationDto
    {
        public GetReservationDto(Reservation reservation)
        {
            ArrivalDate = reservation.ArrivalDate;
            DepartureDate = reservation.DepartureDate;
            NumberOfChildren = reservation.NumberOfChildren;
            NumberOfAdults = reservation.NumberOfAdults;
            Ref = reservation.Ref;
            User = new GetReservationDto.GetReservationUserDto()
            {
                Ref = reservation.User.Ref,
                Name = reservation.User.Name,
                Email = reservation.User.Email
            };
        }

        public class GetReservationUserDto
        {
            public Guid Ref { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }

        public Guid Ref { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public GetReservationUserDto User { get; set; }
    }
}