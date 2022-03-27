namespace Sample_4_9_example
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ビンゴのマスの縦・横のサイズを入力：");
            int size = int.Parse(Console.ReadLine());
            Bingo sheet = new Bingo(size);
            sheet.Show();
        }
    }
}
