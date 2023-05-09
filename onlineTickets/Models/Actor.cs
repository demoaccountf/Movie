using System.ComponentModel.DataAnnotations;

namespace onlineTickets.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
