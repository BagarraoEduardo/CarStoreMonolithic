using CarStore.Business.Interface;
using CarStore.Models;
using Microsoft.AspNetCore.Http;

namespace CarStore.Business
{
    public class ShoppingCartService : IShoppingCartService
    {
        private IHttpContextAccessor _contextAcessor;
        private ILogger _logger;

        public ShoppingCartService(
            IHttpContextAccessor contextAcessor,
            ILogger logger)
        {

            _contextAcessor = contextAcessor;
            _logger = logger;

        }

        public async Task<ShoppingCart> GetShoppingCart()
        {
            try
            {
                var session = _contextAcessor.HttpContext.Session;
                var shoppingCartId = session?.Id != null ? new Guid(session.Id) : Guid.NewGuid();

                session.SetString("ShoppingCartIdD", shoppingCartId.ToString());

                return new ShoppingCart()
                {
                    Id = shoppingCartId
                };
            }
            catch (Exception exception) 
            {
                _logger.LogError("An exception has ocurred.", exception);
                throw;
            }
        }
    }
}
