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
            PrintIntegersDo();
            PrintExcludingFor();
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
         * Question1 (B)
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

        /*
         * Question 1 (C)
         * Desc : Write a third method called PrintIntegersDo
         * using a do while loop.
         */

        static void PrintIntegersDo()

        {
            int i = 40;
            

            do
            {
                
                Console.WriteLine(i);
                i++;
            }
            while (i < 60);
            
        }
    }

    /*
    * Question 1 (D)
    * Desc : Write a method called PrintExcludingFor
    * using a for loop
    * excluding numbers 46 and 48
    */

         static void PrintExcludingFor()

         {

         for (int i = 40; i <= 60; i++)
         {
            Console.WriteLine(i);

         }
      }
    }

