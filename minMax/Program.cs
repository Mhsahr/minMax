using System;
using System.Linq;
using System.Collections.Generic;

namespace maxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }
            {
                int result = numbers.Max();
                Console.WriteLine("The max number is " + numbers.Max());

                int answer = numbers.Min();
                Console.WriteLine("The min number is " + numbers.Min());
            }

        }
    }
}
