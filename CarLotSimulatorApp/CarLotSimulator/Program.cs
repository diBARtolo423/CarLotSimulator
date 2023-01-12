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


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var wrangler = new Car();
            wrangler.Make = "Jeep";
            wrangler.Model = "Wrangler";
            wrangler.Year = 2023;
            //rossCarLot.carList.Add(wrangler);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");



            //wrangler.CarType();

            //var viper = new Car();
            //viper.Make = "Dodge";
            //viper.Model = "Viper";
            //viper.Year = 2001;

            //viper.CarType();

            //var corvette = new Car();
            //corvette.Make = "Chevy";
            //corvette.Model = "Stringray";
            //corvette.Year = 2023;

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //var wrangler = new Car();
            //wrangler.Make = "Jeep";
            //wrangler.Model = "Wrangler";
            //wrangler.Year = 2023;

            var viper = new Car("Dodge", "Viper", 2001);
            //rossCarLot.carList.Add(viper);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");



            var corvette = new Car()
            {
                Make = "Chevy",
                Model = "Stingray",
                Year = 2023
            };
            //rossCarLot.carList.Add(corvette);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");


            Console.WriteLine();

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //var carList = new List<Car>() { wrangler, viper, corvette };
            foreach (var car in CarLot.carList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
        }
    }
}
