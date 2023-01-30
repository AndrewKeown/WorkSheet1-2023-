using System;

namespace Worksheet1__Q2_
{
    /* Name : Andrew Keown
     * Desc : Question 2 (A)
     * 
     * Write a method called CountOddNumbers, which reads in 5 int values from the console
     * and returns the number of them which are odd
     */
    internal class Program
    {
        static int[] numbers = new int[5];
        static void Main(string[] args)
        {
            CountOddNumbers();

            AverageMinMax();
        }
        
        static void CountOddNumbers()
        {
            int oddnumbers = 0;

            Console.WriteLine("Enter five numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2) == 1 || (numbers[i] % 2 == -1 ))
                {
                    oddnumbers = oddnumbers + 1;
                }
                    oddnumbers = oddnumbers + 1;
            }
            Console.WriteLine($"you have entered {oddnumbers} oddnumbers");

        }

        /* Desc : Question 2 (A)
         *
         * Write a method called AverageMinMax, to read in 5 int values from the console
         * and outputs the number entered and the largest number entered
         */

        static void AverageMinMax()
        {
            int maxValue = 0;
            int minValue = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                minValue = numbers.Min();
            }

            Console.WriteLine($"The highest number is {maxValue} and the lowest is {minValue}");

        }
    }
}
    
