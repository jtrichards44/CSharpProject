using System.Collections.Generic;

namespace Final.Models
{
    public class Platform
    {
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }

        public ICollection<VideoGame> Videogames { get; set; }
    }

    public enum PlatformSelections
    {
        Switch,
        Playstation,
        Xbox,
        PC
    }
}
