using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251010
{
    class Program
    {
        static void Main(string[] args)
        {
            //주석 -> 컴파일 무시, 설명이나 전달할 사항
            /*주석*/

            Console.Title = "2025-10-10";

            /*
            자주 사용되는 변수(자료형)

            int     정수  4byte

            //부동소수점형식
             - 정수뿐만 아니라 유리수를 포함하는 실수영역에서 데이터를 다룰 때 사용하는 말
             - 정수 형식을 대체하지 못한다

            float   실수  4byte   소수점 7자리까지(8자리수에서 반올림)   단일정밀도 부동소수점형식
            double  실수  8byte   소수점 15자리까지(16자리수에서 반올림) 복수정밀도 부동소수점형식

            char    문자  2byte   한문자를 담을 수 있는 공간 
            string  문자열 사용되는 문자열의 크기에 따라 byte가 지정됨

            boolean 참과 거짓을 나타낼때 사용하는 자료형 1byte
            */

            //Using으로 System.생략
            Console.Write("안녕 내이름은 서종오이다"); //출력이후줄바꿈없음
            Console.WriteLine("안녕 내이름은 서종오이다"); //출력이후줄바꿈있음
            
            //입력을 받으려면 담을 공간(변수)를 선언해야한다
            //한글도 가능하긴 하다

            String 생일;
            Console.Write("생일을 입력하세요 : ");
            생일 = Console.ReadLine(); //ReadLine은 String형식
            Console.WriteLine($"당신의 생일은 {생일}이군요");

            String birthday;
            Console.Write("생일을 입력하세요 : ");
            birthday = Console.ReadLine();
            Console.WriteLine($"당신의 생일은 {birthday}이군요");

            float f_pi = 3.1415926535121234f;
            double d_pi = 3.1415926535121234;

            //$의 차이
            Console.WriteLine($"float형태의 pi {f_pi}");
            Console.WriteLine("float형태의 pi "+ f_pi);

            Console.WriteLine($"double형태의 pi {d_pi}");

            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.WriteLine(e);

            int char_a = 'A';
            Console.WriteLine(char_a);//아스키코드 65가 나옴

            a = (char)char_a; //int->char 명시적형변환
            Console.WriteLine(a);
            
            char B = 'B';
            Console.WriteLine((int)B); //char->int 명시적형변환 아스키코드 66이 나옴
            
            int int1 = 1;
            int Int1 = 2;
            Console.WriteLine($"{int1}, {Int1}"); //변수 대소문자 구분
            
            bool isman = true;
            Console.WriteLine(isman);
            isman = false;
            Console.WriteLine(isman);
            
        }
    }
}
