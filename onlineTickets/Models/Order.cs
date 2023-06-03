using System.ComponentModel.DataAnnotations;

namespace onlineTickets.Models
{
    public class Order
    {
        [Key] 
        public int id { get; set; }

        public string Email { get; set; }

        public string userId { get; set; }

        public List <OrderItem> OrderItems { get; set; }
    }
}
