using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class P10_Largest
    {
        public static void FindLargest()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The First Number " + num1 + " is largest among 3 numbers");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The Second Number " + num2 + " is largest among 3 numbers");
            }
            else
            {
                Console.WriteLine("The Third Number " + num3 + " is largest among 3 numbers");
            }
        }
    }
}
