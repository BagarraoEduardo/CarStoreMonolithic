using CarStore.DataAccess.Interface.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CarStore.DataAccess.Interface
{
    public interface ICarStoreUnitOfWork
    {
        public ICarRepository CarRepository { get; }
        public IFuelTypeRepository FuelTypeRepository { get; }
        public ICarTypeRepository CarTypeRepository { get; }

        void SaveAsync();
    }
}
