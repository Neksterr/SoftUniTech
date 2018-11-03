using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                    sumOdd += currentNumber;

                





            }
                int result = sumEven - sumOdd;

                Console.WriteLine(result);
        }
    }
}
