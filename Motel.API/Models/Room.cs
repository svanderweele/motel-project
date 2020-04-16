using System.Text.Json.Serialization;

namespace Motel.API.Models
{
    public class Room
    {
        public int Id { get; set; }

        public int RoomLayoutId { get; set; }
        [JsonIgnore] public virtual RoomLayout RoomLayout { get; set; }
    }
}