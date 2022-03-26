// See https://aka.ms/new-console-template for more information

namespace Sample404
{
    class Program
    {
        static public void Main(string[] args)
        {
            Access a = new Access();
            // a.Data1 = 1;
            a.Data2 = 2;
            a.ShowData();

            Console.WriteLine($"a.data1 = {a.Data1}");
            // Console.WriteLine($"a.data2 = {a.Data2}");
        }
    }
}

