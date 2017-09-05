using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad;
            double area;

            Console.WriteLine("Enter a radius:");
            rad = double.Parse(Console.ReadLine());

            while (rad < 0)
            {
                Console.WriteLine("Must be a positive number");
                rad = double.Parse(Console.ReadLine());
            }

            area = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine("The area of a circle with radius " + rad.ToString() + " is: " + area.ToString());
            Console.ReadKey();
        }
    }
}
