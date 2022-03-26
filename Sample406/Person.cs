namespace Sample406
{
    public class Person
    {
        private string name = "";
        private int age = 0;

        public Person() : this("名無し", 0)
        {
            Console.WriteLine("引数なしのコンストラクタ");
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"引数ありのコンストラクタ 名前:{name} 年齢:{age}");
        }

        public void ShowAgeAndName()
        {
            Console.WriteLine($"名前：{name} 年齢：{age}");
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
