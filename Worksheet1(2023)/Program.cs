namespace Worksheet1_2023_
/* 

* Name : Andrew Keown 

* Desc : Question 1 

* Write a method called PrintIntegersFor which uses a for loop to print all the integers 

* between 40 and 60 in ascending order to the console 

*/

{

    internal class Program

    {

        static void Main(string[] args)

        {

            PrintIntegersFor();

        }





        static void PrintIntegersFor()

        {

            for (int i = 40; i <= 60; i++)

            {

                Console.WriteLine(i);

            }

        }

    }

}