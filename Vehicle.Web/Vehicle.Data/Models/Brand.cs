namespace Vehicle.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Brand
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(CarBrandMaxLength)]
        public string Name { get; set; }

        ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
