﻿using System;

namespace Overloading
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if(isTrue)
            {
                sum = num1 + num2;

                response = (sum == 1) ? $"{sum} dollar." : $"{sum} dollars.";
            }
            return response;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 1, true));
            Console.WriteLine();
            Console.WriteLine(Add(-5, 6, true));
            Console.WriteLine();
            Console.WriteLine(Add(9, 7, true));
            Console.WriteLine();
        }
    }
}
