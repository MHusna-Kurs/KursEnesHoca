using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_11_2022_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi();
            audi.start();
            audi.accelerate();
            audi.slowDown();
            audi.stop();

            Console.ReadLine();
        }
    }
}
