using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
            CarLot.carList.Add(this);
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            CarLot.numberOfCars++;
            CarLot.carList.Add(this);
        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine($"This is the sound of an engine {EngineNoise}.");
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine($"This is the sound of a horn{HonkNoise}.");
        }

        public void CarType()
        {
            Console.WriteLine($"{Year} {Make} {Model}");
        }
    }
}
