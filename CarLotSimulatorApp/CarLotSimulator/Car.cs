using System;
using System.Collections.Generic;
namespace CarLotSimulator
{



    public class Car
    {
        // Default Constructor
        public Car()
        {

        }
        // Permaterized Constructor
        public Car(string make, string model, int year, bool IsDriveable, string engineNoise, string honkNoise)
        {
            Make = make;
            Model = model;
            Year = year;
            Driveable = IsDriveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }

        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Driveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        //Methods

        public void Information()
        {
            Console.WriteLine("\n\n---------------------");
            Console.WriteLine("Vehicle Information");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Make of vehicle: {Make}");
            Console.WriteLine($"Model of vehicle: {Model}");
            Console.WriteLine($"Manufacture date: {Year}");
            if (Driveable == true)
            {
                Console.WriteLine($"Operational: Yes");
            }
            else if (Driveable != true)
            {
                Console.WriteLine($"Operational: No");
            }
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"---------------------\n\nSound of engine: {EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"Sound of horn: {HonkNoise}");
        }
    }
}
