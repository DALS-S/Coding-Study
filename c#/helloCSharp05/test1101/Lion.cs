using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1101
{
    public class Lion : Cat
    {
        public override void Eat()
        {
            Console.WriteLine("사자 밥 먹는다");
        }

        public override void grooming()
        {
            Console.WriteLine("사자 갈기 고른다");
        }

        public override void hunt()
        {
            Console.WriteLine("암사자들이 사냥감");
        }
        public override void Sleep()
        {
            Console.WriteLine("하루종일 잠");
        }
    }
}
