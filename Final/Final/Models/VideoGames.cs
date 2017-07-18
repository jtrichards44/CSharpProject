namespace Final
{
    using Models;
    using System.Data.Entity;

    public class VideoGames : DbContext
    {
        public VideoGames()
            : base("name=VideoGame")
        {
        }

        public virtual DbSet<VideoGames> Videogames { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}