using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestDna = new int[n];
            string command = Console.ReadLine();
            int mostSequnceOnes = -1;
            int BiggestLenght = -1;
            int sample = 0;
            int bestSample = 0;
            int bestSum = 0;
            int startIndex = 0;
            int minIndex = int.MinValue;
            while(command!= "Clone them!")
            {
                int[] curDNA = command.
               Split("!", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
                sample++;
                int curCount = 0;
                bool isBestDna = false;
                int endIndex = 0;
                for(int i = 0; i < curDNA.Length; i++)
                {
                    if (curDNA[i] != 1)
                    {
                        continue;
                    }  curCount++;
                  
                    if (curCount > mostSequnceOnes)
                    {
                        mostSequnceOnes = curCount;
                        endIndex = i;
                    }
                    startIndex = endIndex - curCount + 1;
                    curCount = 0;
                }
                
                if (mostSequnceOnes > BiggestLenght)
                {
                    isBestDna = true;
                }else
                {
                    if (startIndex < minIndex)
                    {
                        minIndex = startIndex;
                        isBestDna = true;
                    }
                    else if(startIndex==minIndex)
                    {
                        if (bestSum > curDNA.Sum())
                        {
                            isBestDna = true;
                        }
                    }
                   

                }
                if (isBestDna)
                {
                    bestSample = sample;
                    bestSum = curDNA.Sum();
                    bestDna = curDNA;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(' ', bestDna)}");
        }
    }
}
