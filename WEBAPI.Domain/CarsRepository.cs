using System;
namespace MyFirstAPI.Domain
{
	public static class CarsRepository
	{
        private static List<Car> cars;

        static CarsRepository()
        {
            cars = new List<Car>
    {
    new Car("Toyota", "Corolla", 2021, "Silver", "ABC123"),
    new Car("Honda", "Civic", 2022, "Black", "DEF456"),
    new Car("Ford", "Mustang", 2020, "Red", "GHI789"),
    new Car("Chevrolet", "Camaro", 2021, "Yellow", "JKL012"),
    new Car("BMW", "X5", 2021, "White", "MNO345"),
    new Car("Mercedes-Benz", "E-Class", 2022, "Blue", "PQR678"),
    new Car("Audi", "A4", 2020, "Gray", "STU901"),
    new Car("Volkswagen", "Golf", 2021, "Green", "VWX234"),
    new Car("Tesla", "Model 3", 2021, "Silver", "YZA567"),
    new Car("Nissan", "Altima", 2022, "Black", "BCD890"),
    new Car("Subaru", "Impreza", 2020, "Red", "EFG123"),
    new Car("Lexus", "RX", 2021, "White", "HIJ456"),
    new Car("Hyundai", "Elantra", 2022, "Blue", "KLM789"),
    new Car("Kia", "Sorento", 2020, "Gray", "NOP012"),
    new Car("Mazda", "CX-5", 2021, "Red", "QRS345"),
    new Car("Volvo", "XC60", 2022, "Silver", "TUV678"),
    new Car("Jeep", "Wrangler", 2021, "Green", "WXYZ901"),
    new Car("Porsche", "911", 2020, "Black", "ABC234"),
    new Car("Land Rover", "Range Rover", 2021, "White", "DEF567"),
    new Car("Chevrolet", "Silverado", 2022, "Red", "GHI890"),
    new Car("Ford", "F-150", 2020, "Blue", "JKL123"),
    new Car("Toyota", "Camry", 2021, "Silver", "MNO456"),
    new Car("Honda", "Accord", 2022, "Black", "PQR789"),
    new Car("BMW", "3 Series", 2020, "Gray", "STU012"),
    new Car("Mercedes-Benz", "C-Class", 2021, "White", "VWX345"),
    new Car("Audi", "Q5", 2022, "Blue", "YZA678"),
    new Car("Volkswagen", "Passat", 2020, "Black", "BCD901"),
    new Car("Tesla", "Model S", 2021, "Red", "EFG234"),
    new Car("Nissan", "Rogue", 2022, "Silver", "HIJ567"),
    new Car("Subaru", "Forester", 2020, "Green", "KLM890"),
    new Car("Lexus", "NX", 2021, "White", "NOP123"),
    new Car("Hyundai", "Tucson", 2022, "Black", "QRS456"),
    new Car("Kia", "Optima", 2020, "Blue", "TUV789"),
    new Car("Mazda", "Mazda3", 2021, "Red", "WXYZ012"),
    new Car("Volvo", "S60", 2022, "Silver", "ABC345"),
    new Car("Jeep", "Grand Cherokee", 2020, "Black", "DEF678"),
    new Car("Porsche", "Panamera", 2021, "White", "GHI901"),
    new Car("Land Rover", "Discovery", 2022, "Gray", "JKL234"),
    new Car("Chevrolet", "Equinox", 2020, "Silver", "MNO567"),
    new Car("Ford", "Escape", 2021, "Red", "PQR890"),
    new Car("Toyota", "Rav4", 2022, "Black", "STU123"),
    new Car("Honda", "Pilot", 2020, "Blue", "VWX456"),
    new Car("BMW", "5 Series", 2021, "Gray", "YZA789"),
    new Car("Mercedes-Benz", "GLC", 2022, "White", "BCD012"),
    new Car("Audi", "A6", 2020, "Silver", "EFG345"),
    new Car("Volkswagen", "Tiguan", 2021, "Black", "HIJ678"),
    new Car("Tesla", "Model X", 2022, "Red", "KLM901"),
    new Car("Nissan", "Sentra", 2020, "Silver", "NOP234"),
    new Car("Subaru", "Outback", 2021, "Green", "QRS567"),
    new Car("Lexus", "IS", 2022, "White", "TUV890"),
    new Car("Hyundai", "Santa Fe", 2020, "Black", "WXYZ123"),
    new Car("Kia", "Sportage", 2021, "Gray", "ABC456")
    };
        }

        public static List<Car> GetAllCars()
        {
            return cars;
        }

        public static void AddCar(Car newCar)
        {
            cars.Add(newCar);
        }

        public static void DeleteCar(string licensePlate)
        {
            var car = GetCarByLicensePlate(licensePlate);

            cars.Remove(car);
        }

        private static Car GetCarByLicensePlate(string licensePlate)
        {

            return cars.Where(x => x.LicensePlate == licensePlate).FirstOrDefault<Car>();


        }

        //private static Car CastCar(IEnumerable<Car> cars)
        //{
        //    return cars.First<Car>();
        //}
    }
}

