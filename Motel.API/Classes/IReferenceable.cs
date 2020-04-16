using System;

namespace Motel.API.Classes
{
    public interface IReferenceable
    {
        Guid Ref { get; set; }
    }
}