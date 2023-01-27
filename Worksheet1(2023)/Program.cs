namespace Worksheet1_2023_
/* 

* Name : Andrew Keown 

* Desc : Question 1 (A)

* Write a method called PrintIntegersFor which uses a for loop to print all the integers 

* between 40 and 60 in ascending order to the console 

*/

{

    internal class Program

    {

        static void Main(string[] args)

        {
            
            PrintIntegersFor();
            PrintIntegersWhile();
        }




        /*
         * Question1 (A)
         */
        static void PrintIntegersFor()

        {

            for (int i = 40; i <= 60; i++)

            {

                Console.WriteLine(i);

            }

        }

        /* 
         * Question2 (B)
         * Desc : Write a second method called PrintIntegersWhile
         * using a while loop
         */

        static void PrintIntegersWhile()

        {
            int x = 40;
            int y = 60;
            while (x > y)

            {

                Console.Write(x);
                x++;


            }
                    




        }
    }

}