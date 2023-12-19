using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inch -> cm 변환식
            Console.Write("INCH 입력: ");
            int inch = int.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine(inch + " inch를 변환한 cm 값: " + cm + " cm");
            Console.WriteLine();

            // kg -> pound 변환식
            Console.Write("KG 입력: ");
            int kg = int.Parse(Console.ReadLine());
            double pound = kg * 2.20462262;
            Console.WriteLine(kg + " kg을 변환한 파운드 값: " + pound + " pound");
            Console.WriteLine();

            // 반지름으로 둘레와 넓이 구하기
            Console.Write("반지름 입력: ");
            int halfCircle = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double dulre = 2 * pi * halfCircle;
            double nulbi = pi * halfCircle * halfCircle;
            Console.WriteLine("해당 원의 둘레: " + dulre);
            Console.WriteLine("해당 원의 넓이: " + nulbi);
            Console.WriteLine();

            // int.TryParse 
            // 일반 parse 는 공백을 비롯한 숫자를 입력 하지 않으면 오류 발생, 이를 보완하기 위해 사용
            // 엉뚱한 값을 입력해도 오류 발생 하지 않고 0으로 저장됨.
            const double PI = 3.14;
            int.TryParse(Console.ReadLine(), out int r);
            Console.WriteLine($"둘레 = {2*PI*r}");
            Console.WriteLine($"넓이 = {r*PI*r}");
        }
    }
}
