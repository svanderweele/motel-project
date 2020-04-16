using System;

namespace Motel.API.Classes
{
    public class ReservationQueryParameters : QueryParameters
    {

        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }

    }
}