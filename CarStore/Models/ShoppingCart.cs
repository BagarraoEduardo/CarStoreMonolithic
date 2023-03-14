namespace CarStore.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }

        private List<ShoppingCartItem> Items { get; set; }
    }
}
