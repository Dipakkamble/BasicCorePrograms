using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientRemainder
    {
        public static void FindQuotientRemainder() 
        {
            Console.WriteLine("Enter the dividend");
            int dividend=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            Console.WriteLine("The quotient is {0}", quotient);
            int remainder=dividend % divisor;
            Console.WriteLine("The remainder is {0}", remainder);
        }
    }
}
