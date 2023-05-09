using onlineTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace onlineTickets.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory;
    }
}
