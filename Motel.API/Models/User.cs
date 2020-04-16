using System;
using System.Collections.Generic;

namespace Motel.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public Guid Ref { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

    }
}