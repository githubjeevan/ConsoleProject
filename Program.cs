﻿//Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the u

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{

    public class Assignment1
    {
        public static void Main()
        {
            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);
        }
    }
}

