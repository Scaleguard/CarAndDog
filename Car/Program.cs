using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string markName;
            string modelName;
            string registration;
            string color;
            int odometer;
            int fuel;
            int laps;


            public Car(string _markName, string _modelName, string _color, string registration )
            {
                markName = _markName;
                modelName = _modelName;
                fuel = 60;
                odometer = 0;
                laps = 0;
                Console.WriteLine($"The {modelName} model car has been created.");
            }

            public void ShowCarData()
            {
                Console.WriteLine($"Model name: {modelName}; Mark name: {markName}; Color: {color}; Odometer: {odometer}; Fuel tank: {fuel}; Regreistration: {registration}");
            }

            public void Lap()
            {
                laps += 1;
                fuel -= 5;
                odometer += 100;
            }
         
            public double CompletedLaps
            {
                
                get { return laps, fuel, odometer; }
            }

        }

        static void Main(string[] args)
        {
            Car newCar = new Car("Mustang", "Fastback", "orange", "Jotaro");

            Console.WriteLine($"Number of completed laps: {newCar.CompletedLaps}");

            while (newCar.CompletedLaps != 0)
            {
                newCar.Lap();
            }

            Console.WriteLine($"Number of completed laps: {newCar.CompletedLaps}");

        }
    }
}
