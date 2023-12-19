using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1025_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램 작성
            Console.Write("출생년도 입력: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 12 == 0)
            {
                Console.WriteLine("원숭이 띠");
            }
            else if (year % 12 == 1)
            {
                Console.WriteLine("닭 띠");
            }
            else if (year % 12 == 2)
            {
                Console.WriteLine("개 띠");
            }
            else if (year % 12 == 3)
            {
                Console.WriteLine("돼지 띠");
            }
            else if (year % 12 == 4)
            {
                Console.WriteLine("쥐 띠");
            }
            else if (year % 12 == 5)
            {
                Console.WriteLine("소 띠");
            }
            else if (year % 12 == 6)
            {
                Console.WriteLine("호랑이 띠");
            }
            else if (year % 12 == 7)
            {
                Console.WriteLine("토끼 띠");
            }
            else if (year % 12 == 8)
            {
                Console.WriteLine("용 띠");
            }
            else if (year % 12 == 9)
            {
                Console.WriteLine("뱀 띠");
            }
            else if (year % 12 == 10)
            {
                Console.WriteLine("말 띠");
            }
            else if (year % 12 == 11)
            {
                Console.WriteLine("양 띠");
            }

            // 현재 년도가 무슨 띠 인지 구하는 프로그램을 작성하시오
            int this_year = DateTime.Now.Year % 12;
            switch (this_year)
            {
                case 0:
                    Console.WriteLine("올해는 원숭이 띠 입니다.");
                    break;
                case 1:
                    Console.WriteLine("올해는 닭 띠 입니다.");
                    break;
                case 2:
                    Console.WriteLine("올해는 개 띠 입니다.");
                    break;
                case 3:
                    Console.WriteLine("올해는 돼지 띠 입니다.");
                    break;
                case 4:
                    Console.WriteLine("올해는 쥐 띠 입니다.");
                    break;
                case 5:
                    Console.WriteLine("올해는 소 띠 입니다.");
                    break;
                case 6:
                    Console.WriteLine("올해는 호랑이 띠 입니다.");
                    break;
                case 7:
                    Console.WriteLine("올해는 토끼 띠 입니다.");
                    break;
                case 8:
                    Console.WriteLine("올해는 용 띠 입니다.");
                    break;
                case 9:
                    Console.WriteLine("올해는 뱀 띠 입니다.");
                    break;
                case 10:
                    Console.WriteLine("올해는 말 띠 입니다.");
                    break;
                case 11:
                    Console.WriteLine("올해는 양 띠 입니다.");
                    break;

            }

            // 사용자에게 현재 월을 입력받아 계절을 출력하는 프로그램 작성
            Console.Write("월 입력: ");
            int month = int.Parse(Console.ReadLine());
            if (month > 2 && month < 6) 
            { 
                Console.WriteLine("봄"); 
            }
            else if (month > 5 && month < 9) 
            { 
                Console.WriteLine("여름"); 
            }
            else if (month > 8 && month < 12) 
            { 
                Console.WriteLine("가을"); 
            }
            else if (month > 11 || month < 3) 
            { 
                Console.WriteLine("겨울"); 
            }

            // 현재 월이 무슨 계절인지 구하는 프로그램 작성
            int season = DateTime.Now.Month;
            switch (season)
            {
                case 1:
                    Console.WriteLine("이번 달은 겨울 입니다.");
                    break;
                case 2:
                    Console.WriteLine("이번 달은 봄 입니다.");
                    break;
                case 3:
                    Console.WriteLine("이번 달은 봄 입니다.");
                    break;
                case 4:
                    Console.WriteLine("이번 달은 봄 입니다.");
                    break;
                case 5:
                    Console.WriteLine("이번 달은 봄 입니다.");
                    break;
                case 6:
                    Console.WriteLine("이번 달은 여름 입니다.");
                    break;
                case 7:
                    Console.WriteLine("이번 달은 여름 입니다.");
                    break;
                case 8:
                    Console.WriteLine("이번 달은 여름 입니다.");
                    break;
                case 9:
                    Console.WriteLine("이번 달은 가을 입니다.");
                    break;
                case 10:
                    Console.WriteLine("이번 달은 가을 입니다.");
                    break;
                case 11:
                    Console.WriteLine("이번 달은 가을 입니다.");
                    break;
                case 12:
                    Console.WriteLine("이번 달은 가을 입니다.");
                    break;
            }
        }
    }
}
