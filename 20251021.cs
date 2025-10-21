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
            try
            {
                int[] aarray = new int[5];

                for (int i = 0; i < 6; i++)
                {
                    aarray[i] = i;
                }
            }
            catch (Exception ex)
            {//오류가 나타났을때 들어오는 실행부
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("오류인가?");

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

            //데이터 들어오는 순서에 따른 자료구조
            /*
             *              stack       queue
             *             후입선출     선입선출
             *            먼저->나중   먼저->먼저
             *             컨트롤Z     은행대기표
             *            뒤로가기     인쇄대기열
             *           문자열리버스   
             */

            Stack<int> stack = new Stack<int>();

            for(int i = 1; i<=5; i++)
            {
                stack.Push(i);
            }

            //stack.count는 지속적으로 크기가 변하기 때문에 위에서 저장을 해놓고 사용하는 것이 안전하다
            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                int a = stack.Pop();
                Console.WriteLine(a);
            }

            Queue<int> queue = new Queue<int>();

            for (int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
            }

            count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                int a = queue.Dequeue();
                Console.WriteLine(a);
            }

            //key - value 자료구조
            /*
             * Dictionary   형태가 정해져 있다          
             * hashtable    형태가 정해져 있지 않다      
             * [Key] - [Value]
             */

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("변대한", "변태");
            dictionary.Add("변민섭", "미대오빠");
            dictionary.Add("장재우", "이상하게머리가빨리자람");
            dictionary.Add("박규동", "몰라 그냥 웃어");
            dictionary.Add("김창근", "근신재에서 근을 맡고 있음");
            dictionary.Add("신재호", "근신재에서 신재를 맡고 있음");
            dictionary.Add("김예은", "ㅎㅇ");
            //dictionary.Add("김예은", "ㅂㅇ");

            string key_name = Console.ReadLine();

            while (true)
            {
                Console.Write("별명을 검색할 친구를 입력해 주세요 : ");
                key_name = Console.ReadLine();

                if (dictionary.ContainsKey(key_name))
                {
                    Console.WriteLine(dictionary[key_name]);
                }
                else
                {
                    Console.WriteLine("당신의 이름은 없습니다.");
                }
            }

            Hashtable hashTable = new Hashtable();

            hashTable.Add(1, "변대한");
            hashTable.Add("변대한", 77);
            hashTable.Add('ㄱ', 88);

            
            if (hashTable.ContainsKey(key_name))
            {
                Console.WriteLine(hashTable[key_name]);
            }
        }
    }
}
