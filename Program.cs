using System;

namespace Properties_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code is creating a new object for car
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            // Prints out car2 new code
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            // This code is creating a new object for car2
            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            // Prints out car2 new code
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            // This code is creating a new object for car3
            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
