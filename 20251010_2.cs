using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251010_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //산술연산자
            /*
             
            +   양쪽 피연산자를 더한다
            
            -   왼쪽 피연산자에서 오른쪽 피연산자를 뺀다
            
            *   양쪽 피연산자를 곱한다
             
            /   왼쪽 피연산자를 오른쪽 피연산자로 나눈 몫을 구한다

            %   왼쪽 피연산자를 오른쪽 피연산자로 나눈 나머지를 구한다
                난수 % 4 -> 0 1 2 3

            */

            int a = 20;
            int b = 6;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            int result;

            result = a + b;
            Console.WriteLine("a + b = " + result); //20 + 6
            a = 30;
            result = a - b;
            Console.WriteLine("a - b = " + result); //30 - 6
            a = 15;
            result = a * b;
            Console.WriteLine("a * b = " + result); //15 * 6
            b = 4;
            result = a / b;
            Console.WriteLine("a / b = " + result); //15 / 4
            b = 3;
            result = a % b;
            Console.WriteLine("a % b = " + result); //15 % 3

            /*
             c#은 객체지향 언어이지만 메소드 안에서의 로직은 순차지향을 따라간다.
             즉 순서대로 값이 대입됨에 따라 값이 달라질 수 있다.
             변수 - 데이터를 담는 공간
             자료형 - 데이터의 형태
            */

        }
    }
}
