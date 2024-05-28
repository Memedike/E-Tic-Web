    using EticProje.Models;

namespace EticProje.Dto
{
    public class CartDtoModel
    {
        public List<CartItem> cardItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
