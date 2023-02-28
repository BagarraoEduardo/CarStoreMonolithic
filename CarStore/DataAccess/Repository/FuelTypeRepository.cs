using CarStore.Context;
using CarStore.DataAccess.Interface.Repository;
using CarStore.Models;

namespace CarStore.DataAccess.Repository
{
    public class FuelTypeRepository : IFuelTypeRepository
    {
        private readonly CarStoreContext _context;

        public FuelTypeRepository(CarStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<FuelType> FuelTypes => _context.FuelType;
    }
}
