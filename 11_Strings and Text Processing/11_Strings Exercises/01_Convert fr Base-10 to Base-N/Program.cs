﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_Convert_fr_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> nums = new List<BigInteger>();
            nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            int n = (int)nums[0];
            BigInteger number = nums[1];
            BigInteger remainder;
            string result = string.Empty;

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    remainder = number % n;
                    number /= n;

                    result = remainder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
