using Microsoft.AspNetCore.Mvc;
using Vehicle.Data.Data;
using Vehicle.Web.Models.Cars;

namespace Vehicle.Web.Controllers
{
    public class CarsController : Controller
    {
        private readonly VehicleDbContext data;

        public CarsController(VehicleDbContext data)
            => this.data = data;


        public IActionResult Add()
        {
            return View(new AddCarFormViewModel
            {
                Brands = this.GetCarBrand(),
            });
        }


        [HttpPost]
        public IActionResult Add(AddCarFormViewModel car)
        {
            return View();
        }

        private IEnumerable<CarBrandViewModel> GetCarBrand()
            => data.Brands
            .Select(b => new CarBrandViewModel
            {
                Id = b.Id,
                Name = b.Name,
            })
            .ToList();
    }
}
