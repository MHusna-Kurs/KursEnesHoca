using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_11_2022_v3
{
    class Human: ISkeletalSystem, IImmuneSystem, ICardiovascularSystem
    {
        public bool _sex { get; set; }
        public float _height { get; set; }
        public float _weight { get; set; }

        public Human(bool sex, float height, float weight)
        {
            _sex = sex;
            _height = height;
            _weight = weight;
        }



        public void Speak()
        {
            Console.WriteLine("I am speaking.");
        }

        public void Run()
        {
            Console.WriteLine("I am running.");
        }

        public void AddBone()
        {
            Console.WriteLine("Kemik eklendi.");
        }

        public void AddJoint()
        {
            Console.WriteLine("Eklem eklendi.");
        }

        public void MoveJoint()
        {
            Console.WriteLine("Eklem hareket etti.");
        }

        public int GetWhiteCellCount()
        {
            return 0;
        }

        public void FightVirus()
        {
            Console.WriteLine("Figthing...");
        }

        public void PumpBlood()
        {
            Console.WriteLine("Pumping blood...");
        }

        public int GetBloodAmount()
        {
            return 5;
        }

        public void RouteBlood(int destination)
        {
            Console.WriteLine("Route meter: "+destination);
        }
    }
}
