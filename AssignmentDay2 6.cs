﻿//6.Write a C# program to print all negative elements in an array

//neg elementarry

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class NegElement
    {
        public static void Main()
        {
            int i = 0;
            int[] arr = new int[6];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of negative numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}