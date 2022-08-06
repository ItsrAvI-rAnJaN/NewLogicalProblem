using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public  class Fibonacci
    {
        public static void FibonacciSeries()
        {

            int Num1 = 0;
            int Num2 = 1;
            int Num3;

            // Taking Input from User for Length of Fabonacci Series...
            Console.Write("\nEnter The Nth Length of Fabonacci Series : ");
            int LengthOfFabonacci = Convert.ToInt32(Console.ReadLine());  // Storing Length of Fabonacci Series...

            //printing first & Second term of Fabonacci Series
            Console.Write("Fabonacci series of {0}th lengths are {1} {2}", LengthOfFabonacci, Num1, Num2);

            // Defing Logic For Loop to get the Fabonacci Series..
            for (int i = 2; i < LengthOfFabonacci; i++)
            {
                Num3 = Num1 + Num2;

                //printing term of fabonacci series from 3 to nth Length Enter by User..
                Console.Write(" " + Num3);
                Num1 = Num2;
                Num2 = Num3;
            }
        }
    }
}
