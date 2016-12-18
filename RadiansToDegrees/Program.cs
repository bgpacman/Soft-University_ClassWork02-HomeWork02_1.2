using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            //  degrees = radians*180/Math.PI; 
            var c = (rad * 180 / Math.PI);

            Console.WriteLine(Math.Round(c, 0));
        }
    }
}
