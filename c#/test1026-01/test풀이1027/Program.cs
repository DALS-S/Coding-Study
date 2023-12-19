using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test풀이1027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                #region first Que
                Console.WriteLine("층수 입력");
                int floor = int.Parse(Console.ReadLine());
                for (int i = 1; i <= floor; i++)
                {
                    // 3층인 경우라면 띄어쓰기가 2,1,0 번 나올 것                
                    for (int j = 0; j <= floor - i; j++)
                    {
                        Console.Write(" ");
                    }
                    // 별의 갯수는 1,3,5개 가 될 것
                    for (int j = 0; j < 2 * j - 1; j++)
                    {
                        Console.Write("★");
                    }
                    Console.WriteLine();
                }
                #endregion
            }

            if (false)
            {
                #region second Que
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
                #endregion
            }

            if (false)
            {
                #region thrid Que
                string start = "1";           // 처음에 주어지는 값
                for (int i = 0; i < 20; i++)
                {
                    int count = 0;            // 일고 말하기에서 해당 숫자의 개수(읽을 숫자의 개수)
                    char num = start[0];      // 읽어드릴 숫자
                    string end = "";          // 중간 누적 값
                    Console.WriteLine(i + 1 + "번째 : " + start);
                    for (int j = 0; j < start.Length; j++)
                    {
                        if (num != start[j])
                        {
                            end = end + num + count;
                            num = start[j];
                            count = 1;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    end = end + num + count;
                    start = end;
                }
                #endregion
            }

            if (false)
            {
                #region fourth Que
                int[] lotto = new int[6];
                int bonus = -1;
                Random random = new Random();         // 랜덤 클래스 생성
                for (int i = 0; i < 6; i++)
                {
                    int n = random.Next(1, 46);      // 1~45 까지의 값 삽입
                    bool isDuplicate = false;       // 중복 체크
                    for (int j = 0; j < i; j++)       // 중복 여부 검증
                    {
                        if (n == lotto[j])
                        {
                            Console.WriteLine("중복 값 :: n = " + n + ", j = " + j);
                            foreach (var item in lotto)
                            {
                                if (item == 0)
                                {
                                    break;
                                }
                                Console.Write(item + " ");
                            }
                            isDuplicate = true;
                            i--;
                            break;
                        }
                    }
                    if (isDuplicate)
                    {
                        continue;
                    }
                    lotto[i] = n;
                }
                Console.WriteLine(Environment.NewLine + "로또");
                // Array.Sort(lotto);  // 오름차순 정렬
                // 버블 정령
                for (int i = 0; i < lotto.Length; i++)
                {
                    for (int j = 0; j < lotto.Length - 1; j++)
                    {
                        if (lotto[j] > lotto[j + 1])
                        {
                            int temp = lotto[j];
                            lotto[j] = lotto[j + 1];
                            lotto[j + 1] = temp;
                        }
                    }
                }
                foreach (var item in lotto)
                {
                    Console.Write(item + " ");
                }
                // Environment.NewLine 은 \n 과 같다
                // Environment.NewLine :: os 별로 개행문자가 다르므로 os 마다 다른 개행문자 사용
                Console.WriteLine(Environment.NewLine + "보너스");
                bonus = random.Next(1, 46);
                for (int i = 0; i < 6; i++)
                {
                    if (bonus == lotto[i])
                    {
                        i = -1;
                        bonus = random.Next(1, 46);
                    }
                }
                Console.WriteLine("보너스 번호 : " + bonus);
                #endregion
            }

            if (false)
            {
                #region fifth Que
                Console.WriteLine("층수 입력");
                int f = int.Parse(Console.ReadLine());
                for (int i = 1; i <= f; i++)
                {
                    // 3층인 경우라면 띄어쓰기가 2,1,0 번 나올 것                
                    for (int j = 0; j < f - i; j++)
                    {
                        Console.Write(" ");
                    }
                    // 별의 갯수는 1,3,5개 가 될 것
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < f; i++)
                {
                    // 3층인 경우라면 띄어쓰기가 2,1,0 번 나올 것                
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    // 별의 갯수는 1,3,5개 가 될 것
                    for (int j = 0; j < 2 * (f - i) - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                #endregion
            }

            if (treu)
            {

            }
        }
    }
}
