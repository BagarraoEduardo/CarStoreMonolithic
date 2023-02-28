using CarStore.Context;
using CarStore.DataAccess.Interface.Repository;
using CarStore.Models;

namespace CarStore.DataAccess.Repository
{
    public class CarTypeRepository : ICarTypeRepository
    {
        private readonly CarStoreContext _context;

        public CarTypeRepository(CarStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<CarType> CarTypes => _context.CarType;
    }
}
