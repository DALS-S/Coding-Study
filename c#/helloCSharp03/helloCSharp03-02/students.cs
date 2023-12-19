using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp03_02
{
    public class students
    {
        public int id;
        public string name;

        // 이렇게 매개변수가 있는 생성자를 만들게 되면 매개변수가 없는 생성자는 자연스레 사라짐
        // 원래는 public students() {} 이렇게 빈 생성자가 자동으로 들어감
        // 그래서 product 클래스에서도 public product(){} 이게 있는 거다.
        public students(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
