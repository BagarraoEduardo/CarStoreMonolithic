using CarStore.Models;

namespace CarStore.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentCarType { get; set; }
    }
}
