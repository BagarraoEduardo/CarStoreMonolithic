using CarStore.Context;
using CarStore.DataAccess.Interface;
using CarStore.DataAccess.Interface.Repository;

namespace CarStore.DataAccess
{
    public class CarStoreUnitOfWork : ICarStoreUnitOfWork
    {
        private readonly ICarRepository _carRepository;
        private readonly IFuelTypeRepository _fuelTypeRepository;
        private readonly ICarTypeRepository _carTypeRepository;

        private readonly CarStoreContext _context;

        public CarStoreUnitOfWork(
            ICarRepository carRepository,
            IFuelTypeRepository fuelTypeRepository,
            ICarTypeRepository carTypeRepository,
            CarStoreContext context)
        {
            _carRepository = carRepository;
            _carTypeRepository = carTypeRepository;
            _fuelTypeRepository = fuelTypeRepository;
            _context = context;
        }

        public ICarRepository CarRepository => _carRepository;
        public ICarTypeRepository CarTypeRepository => _carTypeRepository;
        public IFuelTypeRepository FuelTypeRepository => _fuelTypeRepository;


        public async void SaveAsync() => await _context.SaveChangesAsync();
    }
}
