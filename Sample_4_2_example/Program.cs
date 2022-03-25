// See https://aka.ms/new-console-template for more information

namespace Sample_4_2_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英文を入力してください: ");
            string str = Console.ReadLine();
            Console.WriteLine($"大文字：{str.ToUpper()}");
            Console.WriteLine($"小文字：{str.ToLower()}");
        }
    }
}
