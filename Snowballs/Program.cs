using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfSnowBalls = int.Parse(Console.ReadLine());

            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            double bestValue = 0;

            for (int i = 0; i < numberOfSnowBalls; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowbaQuality = int.Parse(Console.ReadLine());

                double currentValue = Math.Pow((snowballSnow / snowballTime), snowbaQuality);


                if (currentValue> bestValue)
                {

                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowbaQuality;
                    bestValue = currentValue;

                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
