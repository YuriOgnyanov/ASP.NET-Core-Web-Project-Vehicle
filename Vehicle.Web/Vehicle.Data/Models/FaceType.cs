namespace Vehicle.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class FaceType
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(FaceTypeMaxLength)]
        public string Name { get; set; }
    }
}
