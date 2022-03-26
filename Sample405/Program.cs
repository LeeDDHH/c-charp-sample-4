namespace Sample405
{
    class Program
    {
        static public void Main(string[] args)
        {
            Person p = new Person();

            p.SetAgeAndName("山田太郎", 26);
            p.Age = 32;

            // p.Name = 36;

            Console.WriteLine($"名前：{p.Name} 年齢：{p.Age}");
        }
    }
}