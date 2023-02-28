using CarStore.Business.Interface;
using CarStore.DataAccess.Interface;
using CarStore.Models;

namespace CarStore.Business
{
    public class CarStoreService : ICarStoreService
    {
        private ICarStoreUnitOfWork _unitOfWork;

        public CarStoreService(ICarStoreUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Car> GetAllCars()
        {
            return _unitOfWork.CarRepository.Cars.ToList();
        }
    }
}
