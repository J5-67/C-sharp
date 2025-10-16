using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251010_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 수를 입력받아 산술연산자 사용해서 결과를 출력
            Console.WriteLine("a를 입력하세요");
            String a = Console.ReadLine();
            Console.WriteLine("b를 입력하세요");
            String b = Console.ReadLine();

            int result = int.Parse(a) + int.Parse(b);

            Console.WriteLine("a + b = " + result);
            result = int.Parse(a) - int.Parse(b);
            Console.WriteLine("a - b = " + result);
            result = int.Parse(a) * int.Parse(b);
            Console.WriteLine("a * b = " + result);
            result = int.Parse(a) / int.Parse(b);
            Console.WriteLine("a / b = " + result);
            result = int.Parse(a) % int.Parse(b);
            Console.WriteLine("a % b = " + result);

            //textRPG 만들기
            int pHP = 100;
            int pAT = 50;
            int mHP = 100;
            int mAT = 25;

            Console.WriteLine("플레이어가 몬스터를 만났다!");
            Console.ReadLine();
            Console.WriteLine($"플레이어의 체력 : {pHP} 몬스터의 체력 : {mHP}");
            Console.ReadLine();
            Console.WriteLine("플레이어의 공격!");
            mHP = mHP - pAT;
            Console.ReadLine();
            Console.WriteLine($"플레이어의 체력 : {pHP} 몬스터의 체력 : {mHP}");
            Console.ReadLine();
            Console.WriteLine("몬스터의 공격!");
            pHP = pHP - mAT;
            Console.ReadLine();
            Console.WriteLine($"플레이어의 체력 : {pHP} 몬스터의 체력 : {mHP}");
            //애플로고 출력문
            /*
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■■■■□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■■■■■■□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■■■■■■■□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■■■■■■■■□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■■■■■■■■□□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■■■■■■■■□□□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■■■■■■□□□□□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□■■■■■■■■■■■■■■■■■■□□□■■■■□□■■■■■■■■■■■■■■■■□□□□□□□□□□");
                Console.WriteLine("□□□□□■■■■■■■■■■■■■■■■■■■■□□□□□□□■■■■■■■■■■■■■■■■□□□□□□□□□□□□");
                Console.WriteLine("□□□□■■■■■■■■■■■■■■■■■■■■■■■□□□■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□");
                Console.WriteLine("□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□");
                Console.WriteLine("□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□");
                Console.WriteLine("□□□□□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□■■■■■■■■■■■■■■■■■□□□■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□■■■■■■■■■■■■■■■□□□□□■■■■■■■■■■■■■■■□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□■■■■■■■■■■■□□□□□□□□□■■■■■■■■■■■□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            */
        }
    }
}
