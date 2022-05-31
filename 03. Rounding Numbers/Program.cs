using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            double[] array = new double[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                array[i] = double.Parse(numbers[i]);
            }
            for(int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"{array[j]} => " +
                    $"{Math.Round((array[j]),MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
