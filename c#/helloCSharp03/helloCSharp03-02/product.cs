using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp03_02
{
    public class product
    {
        // static 이 안 붙은 것들은 인스턴스 변수
        // 인스턴스가 선언 되고 나서야 메모리에 올라가기 때문
        // product p = new product();
        // p.name = "감자";
        // 인스턴스 별로 각자 값이 다를 수 있다.
        public String name;
        public int price;

        // static 이 붙은 것들은 클래스 변수
        // 인스턴스 선언되기 전 즉 프로그램을 시작하자마자 메모리에 올라감
        // product.companyName = "경북농산";
        // product 타입 객체들이 모두 공유한다. 공통적으로 접근 가능
        public static string companyName;
    }
}
