using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_11_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape;
            
            shape = new Circle();
            shape.draw();

            shape = new Square();
            shape.draw();

            shape = new Rectangle();
            shape.draw();

            Console.ReadLine();
        }
    }
}
