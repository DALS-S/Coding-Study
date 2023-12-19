using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1101
{
    public abstract class Animal
    {
        public string Name { get; set; }    
        public string Age { get; set; }

        // 메서드의 구현은 자손 클래스에게 맡긴다
        // 자손 클래스는 의무적으로 오버라이딩 해야함
        public abstract void Eat();
        public abstract void Sleep();
    }
}
