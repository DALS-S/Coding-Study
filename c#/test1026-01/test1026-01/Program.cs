using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1026_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 삼각형 모양 피라미드 만드시오
            Console.WriteLine("-----------------피라미드 만들기-------------------");
            string[] numbers = { "    *", "   ***", "  *****", " *******", "*********" };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            // 풀이
            Console.Write("층수 입력: ");
            int floor = int.Parse(Console.ReadLine());
            for (int i = 1; i <= floor; i++)
            {
                // 3층인 경우라면 띄어쓰기가 2,1,0 번 나올 것                
                for (int q = 0; q <= floor - q; q++)
                {
                    Console.WriteLine(" ");
                }
                // 별의 갯수는 1,3,5개 가 될 것
                for (int q = 0; q < 2 * q - 1; q++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }

            // 5개의 숫자를 입력 받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성하시오.
            Console.WriteLine("-----------------최대/최소 값 구하기-------------------");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("숫자 입력: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("최대 값: " + num.Max());
            Console.WriteLine("최소 값: " + num.Min());
            Console.WriteLine();

            // 아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오.
            // 1, 11, 12, 1121, 122111, 112213
            // 첫번째 수열 : 1
            // 두번째 수열 : 1이 1개 = 11
            // 세번째 수열 : 1이 2개 = 12
            // 네번째 수열 : 1이 1개, 2가 1개 = 1121
            // 다섯번째 수열 : 1이 2개, 2가 1개, 1이 1개 = 122111
            // 여섯번째 수열 : 1이 1개, 2가 2개, 1이 3개 = 112213
            Console.WriteLine("-----------------20번째 수열 값 구하기-------------------");
            string nowString = "1";
            string beforeString = "";
            int limit = 0;
            while (++limit < 21)
            {
                int count = 1;
                char process = nowString[0];
                for (int i = 1; i < nowString.Length; i++)
                {
                    if (nowString[i] == process)
                    {
                        count++;
                    }
                    else
                    {
                        beforeString += process + count.ToString();
                        process = nowString[i];
                        count = 1;
                    }
                }
                beforeString += process + count.ToString();
                if (limit == 20)
                {
                    Console.WriteLine("20번째 수열: " + beforeString);
                }
                nowString = beforeString;
                beforeString = "";
            }
            Console.WriteLine();

            // 로또 번호 생성기
            Console.WriteLine("-----------------로또 번호 생성기-------------------");
            Console.WriteLine("로또 번호 생성");
            int[] lotto = new int[6];
            int j = 0;
            int cnt = 0;
            Random rand = new Random();
            cnt = 0;
            while (cnt < 6)
            {
                int r = rand.Next(1, 46);
                for (j = 0; j < cnt; j++)
                {
                    if (lotto[j] == r)
                    {
                        break;
                    }
                }
                if (cnt == j)
                {
                    lotto[cnt++] = r;
                }
            }
            for (j = 0; j < 6; j++)
            {
                Console.Write("{0,2} ", lotto[j]);
            }
            Console.WriteLine();
            Console.WriteLine();

            // 다이아몬드 모양 출력
            Console.WriteLine("-----------------다이아몬드 만들기-------------------");
            string[] diamond = { "    *", "   ***", "  *****", " *******", "*********", " *******", "  *****", "   ***", "    *" };
            for (int i = 0; i < diamond.Length; i++)
            {
                Console.WriteLine(diamond[i]);
            }
            Console.WriteLine();

            // 12지신 모두 출력           
            Console.WriteLine("-----------------60갑자 출력하기-----------------");
            Console.Write("년도 입력: ");
            int n = int.Parse(Console.ReadLine());
            String gan = "갑을병정무기경신임계";
            char[] zi = { '자', '축', '인', '묘', '진', '사', '오', '미', '신', '유', '술', '해' };
            int y60 = (n - 4) % 60;
            Console.WriteLine();
            Console.WriteLine("{0}년은 {1}{2}년입니다. ", n, gan[y60 % 10], zi[y60 % 12]);
            Console.WriteLine();
        }
    }
}
