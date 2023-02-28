using CarStore.Models;

namespace CarStore.DataAccess.Interface.Repository
{
    public interface IFuelTypeRepository
    {
        IEnumerable<FuelType> FuelTypes { get; }
    }
}
