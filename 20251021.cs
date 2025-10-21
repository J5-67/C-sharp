using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251021_1
{
    class Program
    {
        class Card
        {
            public int num;
            public int parttern;

            public Card(int num, int parttern)
            {
                this.num = num;
                this.parttern = parttern;
            }
        }

        static void Main(string[] args)
        {
            /*
            try
            {
                int[] array = new int[5];

                for (int i = 0; i < 6; i++)
                {
                    array[i] = i;
                }
            }
            catch (Exception ex)
            {//오류가 나타났을때 들어오는 실행부
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("오류인가?");
            */

            //index 기반 자료구조
            /*
             *                  Array        List ArrayList
             *                  정적          동적   동적
             *                           index 기반
             *                   X                O      O
             *                   
             *                   Length             Count
             *                 형태가 정해져 있음 형태가 정해져 있지 않음  
             */

            string[] array = new string[5];
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("이름을 적어주세요");
                array[i] = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            
            List<string> list = new List<string>();

            for (int i = 0; i < 7; i++)
            {
                Console.Write("이름을 적어주세요");
                list.Add(Console.ReadLine());
                Console.Clear();
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            while (list.Count > 0)
            {
                Console.Write("삭제할 숫자를 입력해주세요");
                string str = Console.ReadLine();
                if (list.Remove(str)) //list의 요소 삭제시도
                {
                    Console.WriteLine($"{str}은 삭제가 되었습니다 {list.Count}");

                }
                else
                {
                    Console.WriteLine($"{str}을 찾지 못하였습니다 {list.Count}");
                }
            }

            //ArrayList : 들어갈 데이터의 형태가 정해져 있지 않은 Object 형식으로 되어 있다
            ArrayList arrayList = new ArrayList();
            arrayList.Add("박민우"); //string
            arrayList.Add(1); //int
            arrayList.Add(1.1f);//float
            arrayList.Add(true);//bool
            arrayList.Add(new Card(1,5));//class

            for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"arrayList[{i}] => {arrayList[i]} | Type [{arrayList[i].GetType()}]");
            }
        }
    }
}
