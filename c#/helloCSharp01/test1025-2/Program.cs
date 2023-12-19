using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace test1025_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1~ 100 까지의 합
            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
                num += i;
            };
            Console.WriteLine(num);
            Console.WriteLine();

            /* 가 ~ 힣 까지 출력
             * int korean = 44032;
            while (korean < 55204)
            {
                Console.Write((char)korean);
                korean++;
            }

            for (int i = 44032; i <= 55203; i++)
            {
                Console.Write((char)i);
            }
            */
            for (char i = '가'; i <= '힣'; i++)
            {
                Console.Write(i);
                Thread.Sleep(1);
            }
        }
    }
}
