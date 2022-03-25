// See https://aka.ms/new-console-template for more information

namespace Sample_4_1_example
{
    class Program
    {
        static void Main(string[] args)
        {
			Rectangle r = new Rectangle();

			Console.Write("幅（cm）: ");
			try
			{
				r.SetWidth(double.Parse(Console.ReadLine()));
			}
			catch (Exception e)
			{
				Console.WriteLine($"{e.Message}");
				return;
			}

			Console.Write("高さ（cm）: ");
			try
			{
				r.SetHeight(double.Parse(Console.ReadLine()));
			}
			catch (Exception e)
			{
				Console.WriteLine($"{e.Message}");
				return;
			}

			Console.WriteLine($"面積：{r.GetArea()}cm2");
			Console.WriteLine($"周の長さ：{r.GetPerimeter()}cm");

		}
    }
}