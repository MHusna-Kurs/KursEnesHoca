using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_11_2022_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human efe = new Human(true, 1.85f, 90.0f);

            efe.Speak();
            efe.Run();
            efe.MoveJoint();
            efe.GetWhiteCellCount();
            efe.GetBloodAmount();
            efe.AddJoint();
            efe.AddBone();
            efe.PumpBlood();
            efe.RouteBlood(10);

            Console.ReadLine();
        }
    }
}
