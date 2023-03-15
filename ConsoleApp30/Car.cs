using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Car
    {
        public string Name;
        public string Color;
        public string Author;
        public string Year;
        public string Motor;
        public Car()
        {

        }
    }
    public class CarController
    {
        private List<Car> cars;

        public CarController()
        {
            cars = new List<Car>();
        }
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var c in cars)
                {
                    writer.WriteLine(c.Name);
                    writer.WriteLine(c.Year);
                    writer.WriteLine(c.Motor);
                    writer.WriteLine(c.Color);
                    writer.WriteLine(c.Author); 
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    Car с = new Car();
                    с.Name = reader.ReadLine();
                    с.Year = reader.ReadLine();
                    с.Motor = reader.ReadLine();
                    с.Color = reader.ReadLine();
                    с.Author = reader.ReadLine(); 
                    cars.Add(с);
                }
            }
        }
        public void AddCar()
        {
            Car c = new Car();
            Console.WriteLine("Enter name:");
            c.Name = Console.ReadLine();
            Console.WriteLine("Enter color:");
            c.Color = Console.ReadLine();
            Console.WriteLine("Enter year:");
            c.Year = Console.ReadLine();
            Console.WriteLine("Enter motor:");
            c.Motor = Console.ReadLine();
            Console.WriteLine("Enter author:");
            c.Author = Console.ReadLine(); 
            cars.Add(c);
        }

        public void ShowCars()
        {
            Console.WriteLine("Cars:");
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Name} {car.Year} {car.Color} {car.Motor} {car.Author}");
            }
        }
    }

}
