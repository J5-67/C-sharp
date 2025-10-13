using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251013_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //if문
            //특정조건에 의해 선택적으로 실행이 가능 -> 예외처리

            if(true) //조건부
            {        //실행부
                Console.WriteLine("참");
            }

            int a = 20;

            if (a >= 10)
            {
                Console.WriteLine("a는 10보다 크거나 같다");
            } 
            else if(a > 20)
            {
                Console.WriteLine("a는 20보다 크다");
            }
            else
            {
                Console.WriteLine("a는 10보다 작다");
            }

            int b = 20;

            if (b >= 10)
            {
                Console.WriteLine("첫번째");
            }
            else if (b == 20)
            {
                Console.WriteLine("두번째");
            }
            else if(b <= 20)
            {
                Console.WriteLine("세번째");
            }

            Console.Write("본인의 소주 주량을 입력하세요 : ");
            int soju = int.Parse(Console.ReadLine());
            if(soju > 0)
            {
                if(soju % 2 == 0)
                {
                    Console.WriteLine("짝수");
                }
                else
                {
                    Console.WriteLine("홀수");
                }
            }
            else if(soju == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("음수");
            } 
        }
    }
}
