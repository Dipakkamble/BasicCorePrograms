using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void FindHarmonicNumber()
        {
            double sum = 0,result = 0; 
            Console.WriteLine("Enter the nth harmonic number");
            int N=Convert.ToInt32(Console.ReadLine());
            for(double i=1;i<=N;i++) 
            {
                sum = sum + (1 / i);
                result=sum;
            }
            Console.WriteLine("The sum of nth harmonic is :" + result);
        }
    }
}
