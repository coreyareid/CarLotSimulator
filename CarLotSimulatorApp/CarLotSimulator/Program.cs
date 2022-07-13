using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            // properties way 1
            Car myCar = new Car("Honda", "Civic", 2019, true, "putputputputpffffput...", "BEEEEP!");

            CarLot.carLot.Add(myCar);

            myCar.Information();
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            // properties way 2
            Car richCar = new Car()
            {
                Make = "Porsche",
                Model = "718 Spyder",
                Year = 2016,
                Driveable = true,
                EngineNoise = "VROOOOOOOM!!!",
                HonkNoise = "HOOONK!!!"
            };

            CarLot.carLot.Add(richCar);

            richCar.Information();
            richCar.MakeEngineNoise();
            richCar.MakeHonkNoise();

            // properties way 3
            Car brokeCar = new Car();
            brokeCar.Make = "Ford";
            brokeCar.Model = "Broncos";
            brokeCar.Year = 1980;
            brokeCar.Driveable = false;
            brokeCar.EngineNoise = "ErrrERREREr...";
            brokeCar.HonkNoise = "BePpp";

            CarLot.carLot.Add(brokeCar);

            brokeCar.Information();
            brokeCar.MakeEngineNoise();
            brokeCar.MakeHonkNoise();


            //*************BONUS X 2*************//
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("---------------------");
            foreach (var item in CarLot.carLot)
            {
                Console.WriteLine($"\nCar available: {item.Make}, " +
                    $"Model: {item.Model}, " +
                    $"Year: {item.Year}");
            }
        }
    }
}
