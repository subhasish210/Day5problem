using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class P4_HarmonicNum
    {
        public static void HarmonicNumber()
        {
            int num;
            double s = 0.0;
            Console.WriteLine("Please enter the nth number for print the harmonic series");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("U entered Zero(0)! Please enter a valid number");
            }
            for (int i = 1; i <= num; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
        }
    }
}
