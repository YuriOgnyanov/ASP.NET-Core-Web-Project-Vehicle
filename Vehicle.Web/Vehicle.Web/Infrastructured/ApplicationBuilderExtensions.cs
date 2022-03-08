namespace Vehicle.Web.Infrastructured
{
    using Microsoft.EntityFrameworkCore;
    using Vehicle.Data.Data;
    using Vehicle.Data.Models;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var data = serviceScope.ServiceProvider.GetService<VehicleDbContext>();

            data.Database.Migrate();

            SeedBrands(data);

            return app;
        }

        private static void SeedBrands(VehicleDbContext data)
        {
            if (!data.Brands.Any())
            {
                data.Brands.AddRange(new[]
                {
                    new Brand { Name = "VW"},
                    new Brand { Name = "Mercedes-Benz"},
                    new Brand { Name = "BMW"},
                    new Brand { Name = "Audi"},
                    new Brand { Name = "Opel"},
                    new Brand { Name = "Peugeot"},
                    new Brand { Name = "Renault"},
                    new Brand { Name = "Ford"},
                    new Brand { Name = "Toyota"},
                    new Brand { Name = "Citroen"},
                    new Brand { Name = "Mazda"},
                    new Brand { Name = "Honda"},
                    new Brand { Name = "Nissan"},
                    new Brand { Name = "Fiat"},
                    new Brand { Name = "Seat"},
                    new Brand { Name = "Skoda"},
                    new Brand { Name = "Mitsubishi"},
                    new Brand { Name = "Hyundai"},
                    new Brand { Name = "Kia"},
                    new Brand { Name = "Suzuki"},
                    new Brand { Name = "Volvo"},
                    new Brand { Name = "Subaru"},
                    new Brand { Name = "Alfa Romeo"},
                    new Brand { Name = "Chevrolet"},
                    new Brand { Name = "Dacia"},
                    new Brand { Name = "Land Rover"},
                    new Brand { Name = "Jeep"},
                    new Brand { Name = "Mini"},
                    new Brand { Name = "Lancia"},
                    new Brand { Name = "Chrysler"},
                    new Brand { Name = "Daihatsu"},
                    new Brand { Name = "Ssangyong"},
                    new Brand { Name = "Jaguar"},
                    new Brand { Name = "Smart"},
                    new Brand { Name = "Porsche"},
                    new Brand { Name = "Rover"},
                    new Brand { Name = "Daewoo"},
                    new Brand { Name = "Saab"},
                    new Brand { Name = "Lexus"},
                    new Brand { Name = "Lada"},
                    new Brand { Name = "Dodge"},
                    new Brand { Name = "Infiniti"},
                    new Brand { Name = "Great wall"},
                    new Brand { Name = "Isuzu"},
                    new Brand { Name = "Tesla"},
                    new Brand { Name = "Range Rover"},
                    new Brand { Name = "Moskvich"},
                    new Brand { Name = "UAZ"},
                    new Brand { Name = "Cadillac"},
                    new Brand { Name = "Tata"},
                    new Brand { Name = "Trabant"},
                    new Brand { Name = "Lincoln"},
                    new Brand { Name = "Volga"},
                    new Brand { Name = "Hummer"},
                    new Brand { Name = "Maserati"},
                    new Brand { Name = "Bentley"},
                    new Brand { Name = "Wartburg"},
                    new Brand { Name = "Pontiac"},
                    new Brand { Name = "GAZ"},
                    new Brand { Name = "Iveco"},
                    new Brand { Name = "Rolls Royce"},
                    new Brand { Name = "Acura"},
                    new Brand { Name = "Mahindra"},
                    new Brand { Name = "Ferrari"},
                    new Brand { Name = "Lamborghini"},
                    new Brand { Name = "Maybach"},
                    new Brand { Name = "Aston Martin"}
                });

                data.SaveChanges();
            }
        }
    }
}
