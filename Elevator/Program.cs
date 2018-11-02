using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            double numberOfPeople = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());

            double courses = (int)Math.Ceiling(numberOfPeople / capacity);

            Console.WriteLine(courses);

        }
    }
}
