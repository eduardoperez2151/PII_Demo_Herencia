using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car= new Car();
            car.StartEngine();
            Console.WriteLine($"I can Turn on my car {car.IsOn}");
        }
    }
}
