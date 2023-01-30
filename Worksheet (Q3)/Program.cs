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
    }
}