using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarStore.Models
{
    [Table("CarType")]
    public class CarType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The car type's name is required.")]
        [MaxLength(20, ErrorMessage = "The car type's name must be shorter than 500 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The car type's description is required.")]
        [MaxLength(500, ErrorMessage = "The car type's description must be shorter than 500 characters.")]
        public string Description { get; set; }

        public List<Car> Cars { get; set; }
    }
}
