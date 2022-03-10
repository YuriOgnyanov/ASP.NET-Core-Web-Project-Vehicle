namespace Vehicle.Web.Models.Cars
{
    public class AddCarFormViewModel
    {
        public string Name { get; set; }

        public string Model { get; init; }

        public int Price { get; init; }

        public int Mileage { get; init; }

        public string Description { get; init; }

        public string FaceType { get; init; }

        public int Year { get; init; }

        public string Town { get; init; }

        public string ImageUrl { get; init; }

        public int BrandId { get; init; }

        public IEnumerable<CarBrandViewModel> Brands { get; set; }
    }
}
