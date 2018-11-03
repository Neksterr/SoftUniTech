using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (int.TryParse(input, out int integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double floating))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out char character))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool boolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }



        }
    }
}
