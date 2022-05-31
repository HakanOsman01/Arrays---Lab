using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[countNumbers];
            for(int currentNumber = 0; currentNumber < arrNumbers.Length; currentNumber++)
            {
                int value = int.Parse(Console.ReadLine());
                arrNumbers[currentNumber] = value;
            }
           for(int reverseIndex = countNumbers - 1; reverseIndex >= 0; reverseIndex--)
           {
                Console.Write(arrNumbers[reverseIndex] + " ");

           }
            
        }
    }
}
