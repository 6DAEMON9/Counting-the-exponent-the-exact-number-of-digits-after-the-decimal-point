using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teylor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taylor:");
            Console.WriteLine(Taylor(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine("End");
            Console.ReadKey();
        }
        public static decimal Taylor(decimal x, int num)//28 max, if u want acuuracy 308(14-16), double
        {
            decimal an = 1, sum = 0;//an is start number
            for (decimal n = 0; ; n++)//enless cycle
            {
                sum += an;//sum all factorial
                an = x / (n + 1) * an;//exp function for taylor series
                if (an < Convert.ToDecimal((1 / Math.Pow(10, num))))//if the value is lower than the user entered(acuuracy),then the loop will be interrupted
                    break;
                Console.WriteLine(an);
            }
            return sum;//derivation of the final number
        }
    }
}
