using System;
using System.Collections.Generic;

namespace ListAndStringPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string> { "This", "is", "a", "list", "of", "words" };

            foreach (string item in text)
            {
                if (item.Length == 5)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
