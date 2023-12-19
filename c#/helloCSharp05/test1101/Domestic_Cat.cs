using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1101
{
    public class Domestic_Cat : Cat
    {
        public string master {  get; set; }
        public string name { get; set; }
        
        public override void Eat()
        {
            Console.WriteLine(master + "한테 받아 먹는다");
        }

        public override void grooming()
        {
            Console.WriteLine(name + "자기가 혼자 털 고른다");
        }

        public override void hunt()
        {
            Console.WriteLine(master + "가 밥줘서 사냥 안한다");
        }

        public override void Sleep()
        {
            Console.WriteLine("낮에 자고 밤에 안잔다");
        }
    }
}
