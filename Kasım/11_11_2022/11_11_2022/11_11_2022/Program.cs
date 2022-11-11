using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_11_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer();

            printer.print(new Document());
            printer.print(new Excel());
            printer.print(new Word());

            Console.ReadLine();
        }
    }
}
