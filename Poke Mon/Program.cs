using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int count = 0;

            decimal halfPower = pokePower / 2;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;

                if (pokePower == halfPower)
                {

                    if (exhaustion != 0)
                    {
                        pokePower /= exhaustion;
                    }

                }


            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
