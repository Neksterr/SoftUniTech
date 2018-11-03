using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before: \n" + $"a = {a} \n" + $"b = {b}");

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("After: \n" + $"a = {a} \n" + $"b = {b}");

        }
    }
}
