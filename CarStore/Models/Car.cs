using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarStore.Models
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "The car must have a model")]
        [MaxLength(30, ErrorMessage = "The car's name must be shorter than 30 characters.")]
        public string Model { get; set; }

        [MaxLength(500, ErrorMessage = "The car's description must be shorter than 500 characters.")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "The car's price must be in a valid range.")]
        [Range(0.0, (double) decimal.MaxValue)]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "The car must have mileage.")]
        [Range(0, long.MaxValue)]
        public long Mileage { get; set; }

        [Required(ErrorMessage = "The car must have a year.")]
        [Range(1886, int.MaxValue, ErrorMessage = "The car's year must be in a valid range.")]
        public int Year { get; set; }
        
        [Required(ErrorMessage = "The car need to have a brand.")]
        [MaxLength(20, ErrorMessage = "The car's brand must be shorter than 20 characters.")]
        public string Brand { get; set; }
        
        public string ImageUrl { get; set; }
        

        public int CarTypeId { get; set; }
        public virtual CarType CarType { get; set; }


        public int CarFuelId { get; set; }
        public virtual FuelType FuelType { get; set; }
    }
}
