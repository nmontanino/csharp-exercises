using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ListsPrep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Hardcoded list:
            //List<double> listA = new List<double> { 2, 5, 4, 6, 12, 9, 22, 19, 55, 8 };

            //Input list:
            List<double> listA = new List<double>();
            Console.WriteLine("Enter ten numbers:");

            while (listA.Count < 10)
            {
                double newInt = double.Parse(Console.ReadLine());
                listA.Add(newInt);
            }

            int total = ListSum.Even(listA);

            Console.WriteLine("The sum of the even numbers in the list is: " + total.ToString());
            Console.ReadLine();
        }
    }
}
