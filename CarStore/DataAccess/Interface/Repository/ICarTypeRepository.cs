using CarStore.Models;

namespace CarStore.DataAccess.Interface.Repository
{
    public interface ICarTypeRepository
    {
        IEnumerable<CarType> CarTypes { get; }
    }
}
