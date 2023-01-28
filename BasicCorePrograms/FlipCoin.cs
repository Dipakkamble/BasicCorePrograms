using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public static void FindPercentageFlipCoin() 
        {
            int tailCount = 0, headCount = 0;
            Console.WriteLine("Please Enter the positive number to flip coin");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                double randomInput = random.NextDouble();

                if (randomInput < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Tailcount:{0} Headcount:{1}" ,tailCount,headCount);
            Console.WriteLine("Tail percentage:{0}%",(tailCount*100)/n);
            Console.WriteLine("Head percentage:{0}%",(headCount*100)/n);
        }
    }
}
