using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp05
{
    public class cat : animal
    {
        public cat() 
        { 
            Born();     // animal 을 상속받았기 때문에 호출 가능
        }
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
        public override void Wash()
        {
            //base.Wash();
            Console.WriteLine("물을 싫어해서 씻기기 힘들다");
        }
    }
}
