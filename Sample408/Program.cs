using System;

namespace Sample408
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1\n");
            Dummy d = new Dummy();
            Console.Write("2\n");
            d = null;
            Console.Write("3\n");
        }
    }
}
