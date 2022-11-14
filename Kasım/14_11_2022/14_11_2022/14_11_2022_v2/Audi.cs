using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_11_2022_v2
{
    class Audi : Car, IMachine
    {
        public override void accelerate()
        {
            Console.WriteLine("Audi hızlandı...");
        }

        public override void slowDown()
        {
            Console.WriteLine("Audi yavaşladı...");
        }

        public void start()
        {
            Console.WriteLine("Motor çalıştırıldı...");
        }

        public void stop()
        {
            Console.WriteLine("Motor durduruldu...");
        }
    }
}
