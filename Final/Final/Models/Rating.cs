using System.Collections.Generic;

namespace Final.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string RatingName { get; set; }

        public ICollection<VideoGame> Videogames { get; set; }
    }

    public enum RatingSelections
    {
        E,
        T,
        M
    }
}
