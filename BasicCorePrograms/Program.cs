﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Basic Programs");

            Console.WriteLine("please enter below number");
            Console.WriteLine("1:FlipCoin\n2:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin.FindPercentageFlipCoin();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Please enter the option from above");
                    break;
            }
            Console.ReadLine();
        }
    }
}
