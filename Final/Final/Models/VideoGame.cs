using System;

namespace Final.Models
{
    public class VideoGame
    {
        public int VideoGameID { get; set; }
        public string VideoGameName { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Description { get; set; }
        public bool Rented { get; set; }
        public string UPC { get; set; }

        public string Platform { get; set; }
        public string Rating { get; set; }

        public Platform platform { get; set; }
        public Rating rating { get; set; }
    }
}