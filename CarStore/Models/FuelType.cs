using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CarStore.Models;

namespace FuelStore.Models
{
    [Table("FuelType")]
    public class FuelType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The fuel type's name is required.")]
        [MaxLength(20, ErrorMessage = "The fuel type's name must be shorter than 500 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The fuel type's description is required.")]
        [MaxLength(500, ErrorMessage = "The fuel type's description must be shorter than 500 characters.")]
        public string Description { get; set; }

        public List<Car> Fuels { get; set; }
    }
}
