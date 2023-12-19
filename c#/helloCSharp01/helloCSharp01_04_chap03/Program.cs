using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp01_04_chap03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 삼항 연산자
            // 물음표와 콜론을 통하여 조건물을 한줄로 표현
            int num = int.Parse(Console.ReadLine());
            string result = num % 2 == 0 ? "짝" : "홀";
            // 수식 ? 해당 수식이 참인 경우 : 해당 수식이 거짓인 경우
            Console.WriteLine(result);

            // switch 문
            switch (num)
            {
                case 0:
                    Console.WriteLine("num 값은 0!");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("num은 1~3!");
                    break;
                case 4: // case 밑에 단 한줄의 코드라도 있다면 그밑에는 꼭 break 필요. break 없으면 오류 발생.
                    Console.WriteLine("num은 4");
                    break;
                case 5:
                    Console.WriteLine("num은 5");
                    break;
                    default:
                    break;
            }

            Console.WriteLine("안녕하세요".Contains("안녕"));
        }
    }
}
