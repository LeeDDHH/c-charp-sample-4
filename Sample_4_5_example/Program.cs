namespace Sample_4_5_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力してください：");
            string str = Console.ReadLine();
            Console.WriteLine($"文字列の長さ：{str.Length}");
        }
    }
}
