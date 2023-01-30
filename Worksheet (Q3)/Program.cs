namespace Worksheet__Q3_
{
    /*
     * Name : Andrew
     * Date : 30/01/2023
     * Desc : Question 3 (A)
     * 
     * Write a method called PrintTriangle
     * to print (#) one at a time
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle();
            PrintTriangleUpsideDown();
            PrintTriangleGeneral();
        }

        static void PrintTriangle()
        {
            Console.WriteLine($"#");
            Console.WriteLine($"##");
            Console.WriteLine($"###");
            Console.WriteLine($"####");
            Console.WriteLine($"#####");
        }



        /*
         * Desc : Question 3 (B)
         * 
         * Write another method called PrintTriangleUpsideDown
         * to print the same pattern upside down
         */

        static void PrintTriangleUpsideDown()
        {
            Console.WriteLine();
            Console.WriteLine($"#####");
            Console.WriteLine($"####");
            Console.WriteLine($"###");
            Console.WriteLine($"##");
            Console.WriteLine($"#");
        }

        /*
         * Desc : Question 3 (C)
         * 
         * Write another method PrintTriangleGeneral which takes as a parameter
         * and prints the pattern with the number of rows which was input.
         * 
         * If you call the method with the argument 5, you should get
         * the pattern from A
         */

        static void PrintTriangleGeneral()
        {
            int ans;
            Console.WriteLine($"Please enter in the number of rows you would like");
            ans = int.Parse(Console.ReadLine());

            while (ans > 10)
            {
               Console.WriteLine("#");
               ans++;
            }

            for (int i = 0; i <= ans; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
            
            
            





        }
    }
}