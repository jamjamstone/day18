using System.Threading.Channels;

namespace day18
{
    /*
    abstract class Animal//추상 클래스-> 뼈대 클래스, 불완전한 클래스
    {
        protected int _health;

        public virtual void Move()
        {
            Console.WriteLine("기본 움직임");
        }
        public abstract void Speak();//virtual-> 가상함수-> 재정의 가능한 함수/abstract함수 -> 본문 작성 안됨 자식에게 구현을 강요
        //{
        //   // Console.WriteLine("동물 소리");
        //}
    }

    //abstract 는 반드시 자식클래스에서 구현해야 함 virtual은 해도 되고 안해도 됨
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍");
        }
        public override void Move()
        {
            Console.WriteLine("산책");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("야옹");
        }
        public void Grooming()
        {
            Console.WriteLine("그루밍");
        }
    }
    class Trainer
    {
        Animal[] myDogs;
        Cat[] myCats;
        public void AddAnimalToTeach(Dog toTeach)
        {
            myDogs[0] = toTeach;
        }
        public void AddAnimalToTeach(Cat toTeach)
        {
            myCats[0] = toTeach;
        }
    }
    */

    /**인터페이스-> 일종의 약속, 강제로 제약을 만들어 냄
     * interface Iinteractable
     * {
     *      void 함수명();
     * }
     * 구현할 약속 모음집
     * 추상화 클래스와 차이점이 뭘까?
     * 
     */
    interface IAttackable
    {
        void Attack();
    }
    class Sword: IAttackable
    {

        public void MeleeAttack()
        {
            Console.WriteLine("근접 공격");
        }
        public void Attack()
        {
            Console.WriteLine("칼로 공격");
        }
    }
    class Bow : IAttackable
    {
        public void Snipe()
        {
            Console.WriteLine("저격!");
        }
        public void Attack()
        {
            Console.WriteLine("활로 공격");
        }
    }
    class Player
    {
        IAttackable _weapon;
        public void EquipWeapon(IAttackable weapon)
        {
            _weapon = weapon;
        }
        public void PerformAttack()
        {
            if (_weapon == null)
            {
                Console.WriteLine("장착된 무기가 없습니다. 기본공격!");
            }
            else
            {
                _weapon.Attack();
                //is -> 확인 캐스팅 가능한지 확인할 때, 참 거짓으로 반환
                //as -> 우항이 캐스팅 가능할 시 캐스팅 아니면 null반환
                if(_weapon is Bow)
                {
                    (_weapon as Bow).Snipe();
                }
                else if(_weapon is Sword) 
                {
                    (_weapon as Sword).MeleeAttack();
                }else
                {
                    _weapon?.Attack();
                }


            }


        }
    }
    // 다형성, 업캐스팅, 다운 캐스팅, 형변환

        /*
        abstract class Car
        {
            int x;
            public abstract void Run();
        }
        interface IDrivable
        {
            void Drive();

        }
        class Plane:IDrivable// 인터페이스 안에 존재하는 함수를 반드시 구현해야 한다.
        {//인터페이스는 다중 상속처럼 사용가능, 인터페이스는 요소를 가질 수 없다 반드시
         //기능만 가지고 있음, 추상화 클래스는 상속을 하나만 시킬 수 있다. 마찬가지로 인터페이스는
         //함수를 구현할 수 없음
            float _x;
            float _y;
            public void Flay()
            {
                Console.WriteLine("비행기 탑승");
            }
            public void Drive() 

            {

            }

        }
        class Vehicle:IDrivable
        {
            int _x;
            int _y;
            public void Drive()
            {

            }
            public void loadPeople()
            {
                Console.WriteLine("탑승!");
            }
        }






        /**객체지향의 원칙 -> solid
         * 객체지향 4대 요소
         * 규율을 강제하는 interface라는 것이 있음
         * 이 인터페이스는 한 클래스에도 여러개 적용이 가능하다
         * 공통된 기능을 추려내서 인터페이스로 만들면 편하다
         * 다형성을 활용하여 필요시 인터페이스 형으로 바꿀수도 있음
         *
         */
    


    internal class Program//internal=> 접근 지정자, 다른 프로젝트에서 공유 안됨 오직 같은 프로젝트에서만 공개
    {//인터널은 같은 프로젝트 내에서만 사용가능 다라서 public 메소드에 추가 안됨
        static void Main(string[] args)
        {
            Player player = new Player();   
            player.EquipWeapon(new Bow());// 이 함수는 인터페이스형을 인자로 받지만
            //다형성으로 인해서 인터페이스를 상속받은? 적용받은 Bow와 Sword를 사용 가능하다.
            player.PerformAttack();


            /*
            //다형성, 오버라이드, 추상 클래스, 키워드 is/as
            Dog[] dogs = new Dog[15];
            Cat[] cats = new Cat[15];

            Random rand = new Random();
            Animal[] angs = new Animal[10];
            for (int i = 0; i < 10; i++) 
            {
                if (rand.Next(0, 2) == 0)
                {
                    angs[i] = new Dog();
                }
                else
                {
                    angs[i]= new Cat();
                }
            }
            foreach(var ele in angs)
            {
                ele.Move();
            }
            foreach (var item in angs)
            {
                item.Speak();
            }
            */
            /*
            var array = new ArrayHelper<int>();
            array.SetArrayByLength(5);
            Console.WriteLine(array.GetArrFirstElement());

            Animal animal = new Dog();
            bool isCat;
            if(animal is Cat)//isCat 좌측변수가 우측 자료형이 맞다면 참 반환
            {

            }
           // ((Cat)animal).Grooming();
            (animal as Cat)?.Grooming();
            */

            /*
            Plane plane = new Plane();
            Vehicle vehicle = new Vehicle();
            IDrivable[] Autobots = new IDrivable[10];
            Autobots[0] = vehicle;//인터페이스 형으로 바꾼 뒤 원래 함성배치
            Autobots[1] = plane;
            foreach(var robots in Autobots)//인터페이스를 적용받은 애들은 인터페이스에 보장된 함수를 구축해 놨다.
            {
                robots.Drive();
            }*/


        }
    }
}
