using CSharp.Homework.Class05.Task02.Entities;
using System;

namespace CSharp.Homework.Class05.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first driver: (Bob, Greg, Jill, Anne)");
            string firstDriver = Console.ReadLine();
            Console.WriteLine("Enter second driver: (Bob, Greg, Jill, Anne)");
            string secondDriver = Console.ReadLine();

            Console.WriteLine("Enter car for race: (Hyundai, Mazda, Ferrari, Porcshe)");
            string firstCar = Console.ReadLine();
            Console.WriteLine("Enter second car for race: (Hyundai, Mazda, Ferrari, Porcshe)");
            string secondCar = Console.ReadLine();

            var car = new Car();
            var car2 = new Car();
            #region Drivers
            Driver[] drivers = new Driver[4]
            {
                new Driver(){Name = "Bob", Skill = 7},
                new Driver(){Name = "Greg", Skill = 5},
                new Driver(){Name = "Jill", Skill = 3},
                new Driver(){Name = "Anne", Skill = 4},
            };
            #endregion
            #region Cars 
            Car[] cars = new Car[4]
            {
                new Car(){Model = "Hyundai", Speed = 120},
                new Car(){Model = "Mazda", Speed = 125},
                new Car(){Model = "Ferrari", Speed = 130},
                new Car(){Model = "Porcshe", Speed = 135},
            };
            #endregion

            for (int i = 0; i < cars.Length; i++)
            {
                if (firstCar == cars[i].Model)
                {
                    car = cars[i];
                }
                if (secondCar == cars[i].Model)
                {
                    car2 = cars[i];
                }
            }

            for (int i = 0; i < drivers.Length; i++)
            {
                if(firstDriver == drivers[i].Name)
                {
                    car.Driver = drivers[i];
                }
                if (secondDriver == drivers[i].Name)
                {
                    car2.Driver = drivers[i];
                }
            }

            RaceCars(car, car2);

            Console.ReadLine();
        }

        public static void RaceCars(Car car, Car car2)
        {
            if (car.Speed > car2.Speed)
            {
                Console.WriteLine($"Model: {car.Model} won with Speed: {car.Speed} and Driver: {car.Driver.Name}!");
            }
            else 
            {
                Console.WriteLine($"Model: {car2.Model} won with Speed: {car2.Speed} and Driver: {car2.Driver.Name}!");
            }
        }
    }
}
