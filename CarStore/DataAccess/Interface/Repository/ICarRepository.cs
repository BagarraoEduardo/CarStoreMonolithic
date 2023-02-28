using CarStore.Models;

namespace CarStore.DataAccess.Interface.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }

        Car GetCarById(int id);
    }
}
