using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp05
{
    public class animal
    {
        public static int count = 0;
        public int Age 
        { 
            get; 
            set; 
        }

        protected void Born()   // animal을 상속받은 객체만 호출해서 사용가능
        {
            Console.WriteLine("태어남");
        }
        public void Sleep()
        {
            Console.WriteLine("잔다");
        }
        public void Eat()
        {
            Console.WriteLine("먹는다");
        }

        // 자손 클래스에서 오버라이드를 할 메서드라면 virtual 이라는 키워드 사용해야함
        public virtual void Wash()
        {
            Console.WriteLine("물로 씻깁니다.");

        }
    }
}
