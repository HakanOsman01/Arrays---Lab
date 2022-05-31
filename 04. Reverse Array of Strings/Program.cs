using System;
using System.Linq;

namespace ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] text = Console.ReadLine().Split(' ');
            for (int reverseIndex = text.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                Console.Write(text[reverseIndex] + " ");

            }


        }
    }
}
