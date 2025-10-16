using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251013_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 증감연산자
             * 증가 ++
             * 감소 --
             * 전위연산자 ++a --a -> 동작 후에 연산
             * 후위연산자 a++ a-- -> 연산 후에 동작
             */

            int a = 3;
            int b = 4;
            int result;

            result = a++ + --b;
            Console.WriteLine($"result = {result}, a = {a}, b = {b}");

            result = a-- + ++b;
            Console.WriteLine($"result = {result}, a = {a}, b = {b}");

            /*
             * 관계연산자
             * < > <= >= == !=
             * True / False
             */

            int c = 10;
            int d = 20;

            bool result_b_1 = (c < d);
            bool result_b_2 = (c > d);
            bool result_b_3 = (c <= d);
            bool result_b_4 = (c >= d);
            bool result_b_5 = (c == d);
            bool result_b_6 = (c != d);

            Console.Write(result_b_1 + " ");
            Console.Write(result_b_2 + " ");
            Console.Write(result_b_3 + " ");
            Console.Write(result_b_4 + " ");
            Console.Write(result_b_5 + " ");
            Console.WriteLine(result_b_6);

            /*
             * 논리연산자
             * &&(AND) ||(OR)
             * True / False
             */

            int e = 10;
            int f = 20;

            bool result_c_1 = (e == 9 && f == 20);
            bool result_c_2 = (e >= 9 && f <= 20);
            bool result_c_3 = (e == 9 || f == 20);
            bool result_c_4 = (e >= 9 || f <= 20);

            Console.Write(result_c_1 + " ");
            Console.Write(result_c_2 + " ");
            Console.Write(result_c_3 + " ");
            Console.WriteLine(result_c_4);

            /*
             * not게이트
             * !
             */

            bool not_result = !result_c_4;

            Console.WriteLine(result_c_4);

            /*
             * 비트연산자
             * << >>(쉬프트) & |(논리곱/합) ^(서로다른)
             * 128 64 32 16 8 4 2 1
             */

            int bitnum1 = 15; //0000 1111
            int bitnum2 = 20; //0001 0100

            int And_bit = bitnum1 & bitnum2; //0000 0100 4
            int Or_bit = bitnum1 | bitnum2; //0001 1111 31
            int Xor_bit = bitnum1 ^ bitnum2; //0001 1011 27

            Console.WriteLine($"{And_bit}, {Or_bit}, {Xor_bit}");

            int sh_num = 15; //0000 1111 2배수 늘어난다
            int sh_result1 = sh_num << 1; //0001 1110 30
            int sh_result2 = sh_num << 2; //0011 1100 60
            int sh_result3 = sh_num << 3; //0111 1000 120
            Console.WriteLine($"{sh_result1}, {sh_result2}, {sh_result3}");

            int sh_num1 = 40; //0010 1000 2배수 작아진다
            sh_result1 = sh_num1 >> 1; //0001 0100 20
            sh_result2 = sh_num1 >> 2; //0000 1010 10
            sh_result3 = sh_num1 >> 3; //0000 0101 5
            Console.WriteLine($"{sh_result1}, {sh_result2}, {sh_result3}");

            /*
             * 할당연산자 (복합대입연산자)
             * += -= *= /= %=
             */

            int playerHP = 100;

            Console.WriteLine("플레이어의 체력 = " + playerHP);
            Console.WriteLine("10의 피해를 입었다.");
            playerHP = playerHP - 10;
            Console.WriteLine("플레이어의 체력 = " + playerHP);
            Console.WriteLine("10의 피해를 입었다.");
            playerHP -= 10;
            Console.WriteLine("플레이어의 체력 = " + playerHP);

            int t1 = 10;
            int t2 = 20;
            int t3 = 30;
            Console.WriteLine("test {0} {1} {2}", t1, t2, t3);

            /*
             * 삼항연산자
             * 조건 ? 참 : 거짓 ;
             */

            string name = "박원규";

            string str_result = name == "박원규" ? "지각쟁이" : "나름 정상";
            Console.WriteLine(str_result);
        }
    }
}
