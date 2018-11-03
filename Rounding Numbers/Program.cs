using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double originalNum = numbers[i];
                double roudedNum = Math.Round(originalNum, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{originalNum} => {roudedNum}");
            }

        }
    }
}
