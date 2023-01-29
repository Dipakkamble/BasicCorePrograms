using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {
        public static void FindEvenOdd() 
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0) 
            {
                Console.WriteLine("The number is even");
            }
            else 
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
