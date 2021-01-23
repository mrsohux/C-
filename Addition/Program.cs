using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            main m = new main();
            Console.WriteLine("Ente two numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int ans = m.add(a, b);

            Console.WriteLine($"addition of{a} + {b} is {ans}");
        }
    }
}
