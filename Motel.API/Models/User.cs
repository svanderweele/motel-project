using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Motel.API.Classes;

namespace Motel.API.Models
{
    public class User : ISoftDeletes, IReferenceable
    {
        public int Id { get; set; }
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [NotMapped] public string PasswordPlain { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        [JsonIgnore] public virtual List<Reservation> Reservations { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}