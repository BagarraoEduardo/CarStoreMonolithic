using CarStore.Models;

namespace CarStore.Business.Interface
{
    public interface IShoppingCartService
    {
        Task<ShoppingCart> GetShoppingCart();
    }
}
