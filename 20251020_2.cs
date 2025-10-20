namespace _20251020_2
{
    class Program
    {
        //다형성 : 기준은 메소드로 잡힌다 / 하나의 객체가 여러가지 형태를 가질 수 있다
        //  특징 : 코드 재사용성 / 유연성과 확장성 / 가독성 향상
        //오버라이딩 : 상위 클래스(부모)가 가지고 있는 메소드를 하위 클래스(자식)가 재정의(추상)할 때 사용하는 키워드
        //  상속관계에서 오버라이딩을 사용하는 조건
        //  virtual 키워드가 사용된 메소드 -> 재정의 선택
        //  abstract 키워드가 사용된 메소드 -> 재정의 필수
        //오버로딩 : 하나의 메소드로 여러가지를 구현할 때 사용된다. 키워드는 사용되지 않는다 -> 자동으로 된다.
        //  리턴값이 다른 경우 / 매개변수의 형태가 다른 경우 / 매개변수의 개수가 다른 경우

        //리턴값이 다른 경우 / 매개변수의 형태가 다른 경우
        public int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public float Sum(float a, float b)
        {
            float result = a + b;
            return result;
        }

        // 매개변수의 개수가 다른 경우
        public int Sum (int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }

        
        static void Main(string[] args)
        {
            //Program p = new Program();
            //
            //p.Sum(2, 5);
            //p.Sum(2.1f, 5.1f);
            //p.Sum(2, 5, 7);

            Dog cancho = new Dog();
            DogHuman Dongwon = new DogHuman();

            //재정의된 메소드
            cancho.Sleep();
            Dongwon.Sleep();

            cancho.Speak();//추상메소드 사용 O
            Dongwon.Speak();//추상메소드 사용 X

            cancho.Walk();

            Dongwon.Walk();
            Dongwon.Work();




        }
    }
}

namespace _20251020_2
{
    /*
     *              virtual      abstract          interface
     * 제한사항       없음    클래스가 abstract   없음 / 단독 선언
     * 구현가능여부   가능          불가능            불가능
     * 추상화대상     메소드        클래스
     * 
     */

    public interface IWalk
    {
        //인터페이스는 메소드를 생성하게 되면
        void Walk();
    }

    public interface IWork
    {
        void Work();
    }

    abstract class Animal //추상클래스로 관리를 할 것
    {
        //virtual 사용법
        public virtual void Speak()
        {
            Console.WriteLine("Scream~");
        }

        //abstract 사용법
        public abstract void Sleep();
    }

    class Dog : Animal, IWalk //interface는 다중 상속이 가능하다
    {
        public override void Sleep()
        {
            Console.WriteLine("드르르렁 쿨");
        }

        public override void Speak()
        {
            Console.WriteLine("깽깽 깡 꽁 낑");
            base.Speak();//추상 메소드의 구현부 실행여부
        }

        public void Walk()
        {
            Console.WriteLine("도도하게 사뿐사뿐");
        }
    }

    //인터페이스끼리도 다중 상속이 가능하다
    class DogHuman : Animal, IWalk, IWork
    {
        public override void Sleep()
        {
            Console.WriteLine("드르렁 드르렁");
        }

        public override void Speak()
        {
            Console.WriteLine("이새키 저새키");
        }

        public void Walk()
        {
            Console.WriteLine("터덜터덜");
        }

        public void Work()
        {
            Console.WriteLine("야!");
        }
    }
}
