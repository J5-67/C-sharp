using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251020_1
{
    //                      virtual     abstract    |   interface
    //제한사항                  X    class abstract  | x/clas처럼 선언 단독선언
    //추상클래스안구현부     정의선택    정의불가능     |  정의불가능
    //자식재정의            의무선택     O            |      O
    //상속수                     클래스 -> 1개        | 다중상속가능

    //상속 : 부모 클래스에서 선언한 것을 자식 클래스에서 포함하는 것
     class Parent
    {
        public string name;
        public int age;

        //접근제한자 protected
        protected int money;

        public Parent()
        {
            money = 10000;
        }

        public void viewing_money()
        {
            Console.WriteLine($"내 돈은 {money}야");
        }

        public void Scream(string name)
        {
            Console.WriteLine($"{name}야!");
        }
    }

    //부모의 형태와 비슷하게 만들고 싶다
    class Children : Parent
    {
        //부모가 선언한 변수와 메소드를 자식객체도 똑같이 사용 가능하다
        public Children()
        {
            //protected로 걸린 money 변수는 자식 클래스에서 접근이 가능하다
            money = 100000;
        }

        public void Run() //자식 클래스에서만 선언된 메소드
        {
            Console.WriteLine($"{name} 뛰어요");
        }
    }

    //부모 클래스를 상속받은 자식 클래스들은 전부 들고 올 수 있다.
    //자식 클래스로는 부모 클래스를 들고 올 수 없다.

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Children c = new Children();

            p.name = "박민우";
            p.age = 40;
            p.Scream(p.name);
            //p.money -> Program이라는 클래스에서는 money가 접근이 불가능하다

            c.name = "임혜림";
            c.age = 22;
            c.Scream(c.name);
            c.Run(); //자식 클래스에서만 선언한 메소드는 자식만 사용할 수 있다
            //c.money -> 자식의 변수에서도 접근이 불가능하다

        }
    }
}
