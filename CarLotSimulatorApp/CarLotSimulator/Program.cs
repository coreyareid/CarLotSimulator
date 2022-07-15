using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // properties way 1
            var myCar = new Car("Honda", "Civic", 2019, true, "putputputputpffffput...", "BEEEEP!");

            CarLot.ParkingLot.Add(myCar);
            // Methods
            myCar.Information();
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();

            //--------Exercise 2 for Static Keyword--------//
            Console.WriteLine($"Cars built: {CarLot.numberOfCars}");

            // properties way 2
            var richCar = new Car()
            {
                Make = "Porsche",
                Model = "718 Spyder",
                Year = 2016,
                Driveable = true,
                EngineNoise = "VROOOOOOOM!!!",
                HonkNoise = "HOOONK!!!"
            };

            CarLot.ParkingLot.Add(richCar);

            // Methods
            richCar.Information();
            richCar.MakeEngineNoise();
            richCar.MakeHonkNoise();

            //--------Exercise 2 for Static Keyword--------//
            Console.WriteLine($"Cars built: {CarLot.numberOfCars}");


            // properties way 3
            Car brokeCar = new Car();
            brokeCar.Make = "Ford";
            brokeCar.Model = "Broncos";
            brokeCar.Year = 1980;
            brokeCar.Driveable = false;
            brokeCar.EngineNoise = "ErrrERREREr...";
            brokeCar.HonkNoise = "BePpp";

            CarLot.ParkingLot.Add(brokeCar);

            //Methods
            brokeCar.Information();
            brokeCar.MakeEngineNoise();
            brokeCar.MakeHonkNoise();

            //--------Exercise 2 for Static Keyword--------//
            Console.WriteLine($"Cars built: {CarLot.numberOfCars}");

            Console.WriteLine("---------------------");
            foreach (var item in CarLot.ParkingLot)
            {
                Console.WriteLine($"\nCar available: {item.Make}, " +
                    $"Model: {item.Model}, " +
                    $"Year: {item.Year}");
            }
        }
    }
}
