namespace Vehicle.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Vehicle.Data.Models.Enums;

    using static DataConstants;

    public class Car
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(CarNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(CarModelMaxLength)]
        public string Model { get; set; }

        [Required]
        [Range(CarPriceMin, CarPriceMax)]
        public int Price { get; set; }

        [Required]
        [Range(CarMileageMin, CarMileageMax)]
        public int Mileage { get; set; }

        [Required]
        [MaxLength(CarDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public FaceType FaceType { get; set; }

        [Required]
        [Range(CarYearMinValue, CarYearMaxValue)]
        public int Year { get; set; }

        [Required]
        [MaxLength(CarTownMaxLength)]
        public string Town { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
