using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {

            double meters = double.Parse(Console.ReadLine());

            double km = meters * 0.001;

            Console.WriteLine($"{km:F2}");

        }
    }
}
