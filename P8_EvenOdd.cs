using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class P8_EvenOdd
    {
        public static void EvenOdd()
        {
            int num;
            Console.WriteLine("Enter a number to check");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
