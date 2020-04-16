using System;

namespace Motel.API.Classes
{
    public interface ISoftDeletes
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime DeletedAt { get; set; }
    }
}