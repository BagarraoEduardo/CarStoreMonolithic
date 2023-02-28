using CarStore.Context;
using CarStore.DataAccess.Interface.Repository;
using CarStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStore.DataAccess.Repository
{
    public class CarRepository : ICarRepository
    {
        private CarStoreContext _context;

        public CarRepository(CarStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> Cars => _context.Car
            .Include(car => car.FuelType)
            .Include(car => car.CarType);

        public Car GetCarById(int id) => _context.Car
            .FirstOrDefault(car => car.Id == id);
    }
}
