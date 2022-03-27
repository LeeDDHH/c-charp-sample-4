namespace Sample_4_7_example
{
    public class Student
    {
        private string name;
        private int grade;
        private int age;

        public Student(string name, int grade, int age)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"名前：{name} 学年：{grade} 年齢：{age}");
        }
    }
}
