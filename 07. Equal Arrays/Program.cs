using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().
                 Split(' ').
                 Select(int.Parse)
                 .ToArray();
            int[] secondArr = Console.ReadLine().
                 Split(' ').
                 Select(int.Parse)
                 .ToArray();
            bool isequal = false;
            int sum = 0;
            int indexdiff = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    sum += firstArr[i];
                    continue;
                }
                isequal = true;
                indexdiff += i;
                break;

            }
            if (isequal)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexdiff} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
