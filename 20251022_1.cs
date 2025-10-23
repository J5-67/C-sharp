namespace _20251022_1
{
  class Monster
      {
          public string name;
          public int hp;
          private Random rnd;
  
          public Monster(string name, int hp)
          {
              this.name = name;
              this.hp = hp;
          }
  
          public void Viewing_Monster()
          {
              Console.WriteLine($"몬스터 이름 : {name} | HP : {hp}");
          }
      }
  
      class MonsterManager//게임에서 나오는 모든 몬스터를 관리하도록 한다.
      {
          private static MonsterManager _instance = null;
  
          public static MonsterManager Instance
          {
              get
              {
                  if (_instance == null)
                  {
                      _instance = new MonsterManager();
                  }
                  return _instance;
              }
          }
  
          public List<Monster> monster_List;
  
          private MonsterManager()
          {//생성시에 어떠한 행동을 해야하기 때문에 사용하는 사용자 메소드
              monster_List = new List<Monster>();
          }
  
          public void Create_Monster(string name, int hp)
          {
              monster_List.Add(new Monster(name, hp));
              Console.WriteLine($"{name} 몬스터를 추가하였습니다");
          }
  
          public void AllViewing_monster()
          {
              for (int i = 0; i < monster_List.Count; i++)
              {
                  monster_List[i].Viewing_Monster();
              }
          }
  
      }
  
      public enum State
      {
          Happy,
          Angry,
          Sad
      }
  
      //상태의 규격화
      public interface IState
      {
          void Action();
      }
  
      class People
      {//유한 상태 머신으로만 만드는 class
          public string name;
          private State _state;
  
          public State State
          {
              get
              {
                  switch (_state)
                  {//FSM
                      case State.Happy:
                          Console.WriteLine($"{name}은 행복합니다");
                          break;
                      case State.Angry:
                          Console.WriteLine($"{name}은 화가납니다");
                          break;
                      case State.Sad:
                          Console.WriteLine($"{name}은 슬픕니다");
                          break;
                  }
  
                  return _state;
              }
              set
              {
                  _state = value;
              }
          }
  
          public People(string name)
          {
              this.name = name;
          }
  
      }
  
      class Human
      {
          public string name;
          public Dictionary<State, IState> StateDictionary;
  
          public Human(string name)
          {
              this.name = name;
  
              StateDictionary = new Dictionary<State, IState>();
  
              StateDictionary.Add(State.Happy, new Happy(name));
              StateDictionary.Add(State.Angry, new Angry(name));
              StateDictionary.Add(State.Sad, new Sad(name));
          }
  
      }
  
      class Happy : IState
      {
          private string name;
          public Happy(string name)
          {
              this.name = name;
          }
          public void Action()
          {
              Console.WriteLine($"{name}은 행복합니다.");
          }
      }
  
      class Angry : IState
      {
          private string name;
          public Angry(string name)
          {
              this.name = name;
          }
          public void Action()
          {
              Console.WriteLine($"{name}은 화가납니다.");
          }
      }
  
      class Sad : IState
      {
          private string name;
          public Sad(string name)
          {
              this.name = name;
          }
          public void Action()
          {
              Console.WriteLine($"{name}은 슬픕니다.");
          }
      }
  
      class Test
      {
          public Test()
          {
              Console.WriteLine("안녕 Test Class가 생성이 되었단다");
          }
          public void Call()
          {
              Console.WriteLine("나는 일반 클래스 Test야");
          }
      }
  
      //싱글톤 패턴 클래스
      /*
       * 싱글톤 패턴 : 오직 하나의 객체만을 생성할 수 있는 클래스
       * Static : 정적 메소드 or 정적 변수 -> 선언 즉시 메모리 영역에 떠있음
       * Singleton : 하나의 객체 -> Static 키워드를 사용하나 선언 즉시 떠있지 않음 (null) -> instance 호출 시에는 생성자 호출 (단 1회)
       */
  
      class Singleton
      {
          //자기 자신을 인스턴스화 (자기 자신을 부를 수 있는 멤버 변수로)
          //null을 사용해야하는 이유는 Static으로 선언하는 런타임 동시에 메모리가 할당되기 때문에 꼭 null을 붙여줘야 한다.
          //비어있다. / private static, null필수
          private static Singleton _instance = null;
  
          //프로퍼티에서 get (private를 꺼내기 위함)
          public static Singleton Instance
          {
              get
              {
                  if (_instance == null)
                  {
                      _instance = new Singleton();
                  }
                  return _instance;
              }
          }
  
          public Singleton()
          {
              Console.WriteLine("안녕 나는 싱글턴이야 ");
          }
  
          public void Singleton_call()
          {
              Console.WriteLine("싱글턴이야 불렀니?");
          }
      }
  
      class Program
      {
          static void Main(string[] args)
          {
              //일반 클래스 생성단계
              //Test test = new Test();
              //test.Call();
              //Singleton.Instance.Singleton_call();
  
              Program pro = new Program();
              pro.A();
              pro.B();
  
              // singleton 예제
              MonsterManager.Instance.Create_Monster("고동원", 10000);
              MonsterManager.Instance.Create_Monster("박명훈", 1000);
              MonsterManager.Instance.Create_Monster("임우진", 1000);
              MonsterManager.Instance.Create_Monster("송준엽", 1000);
              MonsterManager.Instance.Create_Monster("심호연", 1000);
              MonsterManager.Instance.Create_Monster("장재우", 1000);
              MonsterManager.Instance.Create_Monster("박원규", 1000);
              MonsterManager.Instance.Create_Monster("정민찬", 1000);
              MonsterManager.Instance.Create_Monster("C#콘솔", 10000000);
              MonsterManager.Instance.Create_Monster("포커", 1000000);
              MonsterManager.Instance.Create_Monster("추상화", 10000);
              MonsterManager.Instance.Create_Monster("박범근", 10000);
              MonsterManager.Instance.Create_Monster("상속", 1000);
              MonsterManager.Instance.AllViewing_monster();
  
              //유한 상태 머신 예제
              People p = new People("박규동");
              State s;
              Console.WriteLine($"{p.name}이 학원을 옵니다. 당신의 기분은?");
              p.State = State.Happy;
              s = p.State;
              Console.WriteLine($"{p.name}이 오다보니 지하철을 못탑니다. 당신의 기분은?");
              p.State = State.Angry;
              s = p.State;
              Console.WriteLine($"{p.name}이 지각을 했습니다. 당신의 기분은?");
              p.State = State.Sad;
              s = p.State;
  
             /*State 패턴
              * 상태 패턴: 상태에 따라 어떠한 결과를 도출하거나 반환하는 형태
              * 객체의 특정 상태에 따라 행위를 달리하는 상황에서 직접적으로 상태를 체크하여
              * 그에따라 행위를 호출하지 않고 / 상태를 객체화(Class & Interface) / 하여 상태가 행동할 수 있도록 위임하는 패턴
              */
  
              Human h = new Human("변대한");
              Console.WriteLine($"{h.name}이 포커를 만들어야 합니다. 당신의 기분은?");
              h.StateDictionary[State.Happy].Action();
              Console.WriteLine($"{h.name}이 포커를 만들어야 합니다. 당신의 기분은?");
              h.StateDictionary[State.Angry].Action();
              Console.WriteLine($"{h.name}이 포커를 만들어야 합니다. 당신의 기분은?");
              h.StateDictionary[State.Sad].Action();
  
          }
  
          public void A()
          {
              Test test = new Test();
              test.Call();
              Singleton.Instance.Singleton_call();
          }
  
          public void B()
          {
              Test test = new Test();
              test.Call();
              Singleton.Instance.Singleton_call();
          }
      }
}
