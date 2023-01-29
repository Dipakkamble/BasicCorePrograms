using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumber
    {
        public static void FindLargestNumber() 
        {
            Console.WriteLine("Enter the first number");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1>n2 && n1>n3) 
            {
                Console.WriteLine("n1 is greater number");
            }
            else if (n2>n1 && n2>n3) 
            {
                Console.WriteLine("n2 is greater number");
            }
            else 
            {
                Console.WriteLine("n3 is greater number");
            }
        }
    }
}
