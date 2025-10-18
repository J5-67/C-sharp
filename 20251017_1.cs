using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251017_1
{
    class PlayerInfo
    {
        //멤버변수 -> 클래스 안에 선언하는 변수
        //멤버변수를 선언할 때는 무조건 접근제한자를 넣기
        //접근제한자를 사용하지 않으면 private가 기본
        public string Name;
        public int Hp;
        private int atk;

        //프로퍼티 : get, set을 만들지 않아도 자동으로 만들어 줄 수 있다
        public int Mp { get; private set; }
        //get -> 값을 불러오는 것은 접근제한자가 public
        //private set -> 값을 설정하는 것은 접근제한자가 private

        public PlayerInfo(string Name, int Hp)
        {
            //this 포인터 : 클래스의 멤버변수
            this.Name = Name;
            this.Hp = Hp;
            atk = 10;
            Mp = 100;
        }
         
        public int get_atk()
        {
            return atk;
        }

        public void set_atk(int atk)
        {
            this.atk = atk;
        }

        //스킬 공격력을 뱉는 메소드
        public int Using_SkillAtk()
        {
            Mp -= 50;
            Console.WriteLine($"{Name}이가 스킬 : 강공격을 한다!");
            return 50;
        }

        //클래스 안에는 메소드(기능)을 만들어서 사용할 수 있다
        public void Viewing_PlayerInfo()
        {
            Console.WriteLine($"이름 : {Name} | 체력 : {Hp} | 공격력 : {atk} | 마나 : {Mp}");
            Console.WriteLine();
        }
    }

    class Program
    {
        //참조 : 메모리 주소에 접근한다.
        //                  Class           Struct
        //공통점                 데이터컨테이너
        //상속                 O                X
        //값의호출형태    참조(얕은 복사)값 복사(깊은 복사)
        static void Main(string[] args)
        {
            #region 기본적인 클래스 생성
            /*
            //클래스 객체화 -> new
            PlayerInfo Player1 = new PlayerInfo();
            //생성자 -> 클래스를 만들 때마다 불러와지는 메소드(기능)
            //생성자는 우리가 선언할 수도 있지만, 요약할 수도 있다 - new PlayerInfo ()
            PlayerInfo Player2 = new PlayerInfo();

            //멤버변수의 접근 방법
            Player1.Name = "장재우";
            Player1.Hp = 80;

            Player2.Name = "안동희";
            Player2.Hp = 100;
            */
            #endregion

            PlayerInfo Player1 = new PlayerInfo("변대한", 80);
            PlayerInfo Player2 = new PlayerInfo("박규동", 100);

            Player1.Viewing_PlayerInfo();
            Player2.Viewing_PlayerInfo();

            //Player1.Name = "변태";
            //Player1.Viewing_PlayerInfo();
            //1이 2에게 10의 피해를 입힘
            Player2.Hp -= Player1.get_atk();
            Player2.Viewing_PlayerInfo();
            //2의 공격력 증가
            Player2.set_atk(40);
            Player1.Hp -= Player2.get_atk();
            Player1.Viewing_PlayerInfo();

            Console.WriteLine($"대한이의 MP : {Player1.Mp}");

            Player2.Hp -= Player1.Using_SkillAtk();
            Player1.Viewing_PlayerInfo();
            Player2.Viewing_PlayerInfo();
        }
    }
}
