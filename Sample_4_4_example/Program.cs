namespace Sample_4_4_example
{
    class Program
    {
        static public void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.Write("幅（cm）: ");
            r.Width = double.Parse(Console.ReadLine());

            Console.Write("高さ（cm）: ");
            r.Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"面積：{r.GetArea()}cm2");
            Console.WriteLine($"周の長さ：{r.GetPerimeter()}cm");
        }
    }
}
