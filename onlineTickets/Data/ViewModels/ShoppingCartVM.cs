using onlineTickets.Data.Cart;

namespace onlineTickets.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }

        public static implicit operator ShoppingCartVM(ShoppingCartVM v)
        {
            throw new NotImplementedException();
        }
    }
}