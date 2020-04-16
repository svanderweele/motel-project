using System;

namespace Motel.API.Classes
{
    public class QueryParameters
    {
        const int _maxSize = 100;
        private int _size = 50;

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = Math.Min(_maxSize, value);
            }
        }

        public string SortBy { get; set; }
        public string SortOrder { get; set; }

    }
}