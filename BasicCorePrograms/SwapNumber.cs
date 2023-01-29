using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumber
    {
        public  static void FindSwapNumber() 
        {
            int temp = 0;
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping {0} {1}",a,b);
            temp = a;
            a=b;
            b=temp;
            Console.WriteLine("After swapping {0} {1}", a, b);
        }
    }
}
