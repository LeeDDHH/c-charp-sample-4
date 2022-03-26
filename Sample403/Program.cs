namespace Sample403
{
    class Program
    {
        static public void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            p1.Name = "山田太郎";
            p1.Age = 19;

            p2.SetAgeAndName("佐藤花子", 23);

            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}