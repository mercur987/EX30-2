namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {//bd sp n hei wid wei dep
            Person person1 = new(DateTime.Now,80,"田中太郎",180,80,60,50,25);
            Console.WriteLine($"名前は{person1.name}、身長は{person1.height}cm、体重は{person1.weight}kg、{person1.Ddcheack(person1.BirthDay)}");
            
            Student student1 = new(DateTime.Now, 80, "伊藤良斗", 170, 80, 60, 60,19,13);
            Console.WriteLine($"名前は{student1.name}、身長は{student1.height}cm、体重は{student1.weight}kg、年齢は{student1.Age}、学生番号は{student1.Student_num}");
            
            Worker worker1=new(DateTime.Now,70,"仕事次郎",175,80,60,65,35,"トヨタ自動車");
            Console.WriteLine($"名前は{worker1.name}、身長は{worker1.height}cm、体重は{worker1.weight}kg、年齢は{worker1.Age}、勤務先は{worker1.Workspeace}");
            
            Fish fish = new(DateTime.Now,10,"マグロ",100,60,50,40);
            Console.WriteLine($"名前は{fish.name}、身長は{fish.height}cm、体重は{fish.weight}kg、寿命は{fish.Span}年");
            
            Refrigerator refrigerator1 = new("冷蔵庫", 170, 100, 50, 100);
            Console.WriteLine($"名前は{refrigerator1.name}、高さは{refrigerator1.height}cm、入る箱の大きさは{refrigerator1.height*refrigerator1.width*refrigerator1.depth/1000000}立方ｍ、重さは{refrigerator1.weight}");
            
            Insect insect1 = new(DateTime.Now, 2, "カブトムシ", 7, 30, 10, 7);
            Console.WriteLine($"名前は{insect1.name}、身長は{insect1.width}cm、体重は{insect1.weight}g、寿命は{insect1.Span}ヶ月");

            Car car1=new("プリウス",176,457,1400,147);
            Console.WriteLine($"名前は{car1.name}、全長は{car1.width}cm、入る箱の大きさは{car1.height*car1.width*car1.depth/1000000}立方ｍ、重さは{car1.weight}kg");

            Cat cat1 = new(DateTime.Now, 12, "三毛猫", 27, 30, 4, 50);
            Console.WriteLine($"名前は{cat1.name}、身長は{cat1.height}cm、体重は{cat1.weight}kg、寿命は{cat1.Span}年");

            Plant plant1 = new Plant(DateTime.Now, 2, "チューリップ", 30, 20, 2, 20);
            Console.WriteLine($"名前は{plant1.name}、身長は{plant1.height}cm、寿命は{plant1.Span}年");
        }
    }
    class Things
    {
        public string name;
        public float height;
        public float width;
        public float weight;
        public float depth;
        public Things(string n=null,float hei=0,float wid=0, float wei = 0 ,float dep = 0)
        {
            name = n;
            height = hei;
            width = wid;
            weight = wei;
            depth = dep;
        }
    }
    class Life : Things
    {
        readonly private DateTime birthDay = new DateTime();
        readonly private float span;
        public DateTime BirthDay
        {
            get { return birthDay; }
        }
        public float Span
        {
            get { return span; }
        }
        public Life(DateTime bd, float sp=0, string n = null, float hei = 0, float wid = 0,　float wei=0, float dep = 0) : base(n,hei,wid,wei,dep)
        {
            birthDay = bd;
            span = sp;
        }
    }
    class Refrigerator : Things
    {
        public Refrigerator(string n, float w = 0, float h = 0, float d = 0, float we = 0) : base(n, w, h, d, we)
        {

        }
    }
    class Car : Things
    {
        public Car(string n, float w = 0, float h = 0, float d = 0, float we = 0) : base(n, w, h, d, we)
    {

    }
}
class Plant : Life
    {
        public Plant(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0) : base(bd,sp,n, hei, wid,wei, dep)
        {

        }
    }
    class Animal : Life
    {
        public Animal(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0) : base(bd, sp, n, hei, wid,wei, dep)
        {

        }
    }
    class Fish : Animal
    {
        public Fish(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0) : base(bd, sp, n, hei, wid, wei, dep)
        {

        }
    }
    class Insect : Animal
    {
        public Insect(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0) : base(bd, sp, n, hei, wid, wei, dep)
        {

        }
    }
    class Cat : Animal
    {
        public Cat(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0) : base(bd, sp, n, hei, wid, wei, dep)
        {

        }
    }
    class Person : Animal
    {
        readonly int age;
        public int Age
        {
            get { return age; }
        }
        public Person(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0,int age=0) : base(bd, sp, n, hei, wid, wei, dep)
        {
            this.age = age;
        }
        public string Ddcheack(DateTime dateTime)
        {
            string bdm = "";
            if (DateTime.Now == dateTime)
            {                
                return bdm="誕生日です";
            }
            else
            {
                return bdm = "誕生日ではないです";
            }
        }
    }
    class Student : Person
    {
        readonly private float student_num;
        public float Student_num
        {
            get { return student_num; }
        }

        public Student(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0, int age = 0, float num=0) : base( bd, sp, n, hei, wid, wei, dep,age)
        {
            student_num = num;
        }
    }
    class Worker:Person
    {
        readonly string workspeace;
        public string Workspeace
        {
            get { return workspeace; }
        }
        public Worker(DateTime bd, float sp = 0, string n = null, float hei = 0, float wid = 0, float wei = 0, float dep = 0, int age = 0,string ws = null) : base(bd, sp, n, hei, wid, wei, dep,age)
        {
            workspeace = ws;
        }
    }
}