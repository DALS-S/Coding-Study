using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("for 문 결과");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(i+"번째: ");
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            Console.WriteLine("forEach 문 결과");
            // i = numbers 안에 있는 값들 각각을 의미함
            // java의 for(int item : numbers) 와 같음
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
