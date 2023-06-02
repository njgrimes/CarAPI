using System;
namespace MyFirstAPI.Domain;

    public class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }
        public string? LicensePlate { get; set; }
        // Additional properties can be added as needed'

        public Car()
        {

        }

        public Car(string make, string model, int year, string color, string licensePlate)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.LicensePlate = licensePlate;
        }
}



