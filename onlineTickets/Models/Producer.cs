using System.ComponentModel.DataAnnotations;

namespace onlineTickets.Models
{
    public class Producer
    {
        [Key]
        public int id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

    }
}
