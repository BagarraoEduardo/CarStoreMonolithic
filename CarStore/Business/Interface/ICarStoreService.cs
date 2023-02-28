using CarStore.Models;

namespace CarStore.Business.Interface
{
    public interface ICarStoreService
    {
        List<Car> GetAllCars();
    }
}
