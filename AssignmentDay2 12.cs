﻿
//12.Write a C# function to find whether a given number is prime. It should returns a Boolean true if the number if prime, else returns Boolean false

//boolean number

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CheckPrimeNo
    
    {
        public static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static void Main()
        {
            Console.Write("\n\nFunction : To check a number is prime or not :\n");

            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (chkprime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
}

