using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1101
{
    public class Tiger : Cat
    {
        public string name { get; set; }
        public override void Eat()
        {
            Console.WriteLine(name + "밥 먹는다");
        }

        public override void grooming()
        {
            Console.WriteLine("서로 핥아준다");
        }

        public override void hunt()
        {
            Console.WriteLine("다같이 사냥한다");
        }

        public override void Sleep()
        {
            Console.WriteLine("호랑이 잘 잔다");
        }
    }
}
