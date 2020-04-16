using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Motel.API.Models
{
    public class RoomLayout
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore] public virtual List<Room> Rooms { get; set; }
    }
}