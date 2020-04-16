using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Motel.API.Models
{
    public class Reservation
    {

        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ArrivalDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DepartureDate { get; set; }

        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }

        public int UserId { get; set; }
        [JsonIgnore] public virtual User User { get; set; }
    }
}