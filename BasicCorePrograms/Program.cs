using System;
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

            Console.WriteLine("\nplease enter below number");
            Console.WriteLine("1:FlipCoin\n2:LeapYear\n3:PowerOfTwo\n4:Harmonic\n6:Q&R\n7:SwapNumber");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin.FindPercentageFlipCoin();
                    break;
                case 2:
                    LeapYear.FindLeapYear();
                    break;
                 case 3:
                    PowerOfTwo.FindPowerOfTwo();
                    break;
                case 4:
                    HarmonicNumber.FindHarmonicNumber();
                    break;
                case 6:
                    QuotientRemainder.FindQuotientRemainder();
                    break;
                case 7:
                    SwapNumber.FindSwapNumber();
                    break;
                default:
                    Console.WriteLine("Please enter the option from above");
                    break;
            }
            Console.ReadLine();
        }
    }
}
