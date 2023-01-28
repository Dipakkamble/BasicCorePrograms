using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void FindPowerOfTwo()
        {
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n&&n<=31; i++) 
            {
                double result = Math.Pow(2, i);
                Console.WriteLine("{0} power {1} : {2}",2,i,result);
                
            }
        }
    }
}
