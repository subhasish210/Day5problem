using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class P5_facts
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the prime factization for N: ");
            long n = Convert.ToInt32(Console.ReadLine());

            Console.Write("The prime factization of " + n + " is: ");

            for (long fact = 2; fact * fact <= n; fact++)
            {

                while (n % fact == 0)
                {
                    Console.Write(fact + " ");
                    n = n / fact;
                }
            }
        }
    }
}
