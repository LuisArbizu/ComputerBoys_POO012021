using System;

namespace IntroGithub
{
    class Program
    {
        static void Main(string[] args)
        {

            // Primera Modificacion por Luis Arbizú

            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} - {b} equals {AddNumbers(a,b)} ");
        }
        static int AddNumbers(int a, int b)
        {

            return a - b;

        }
    }
}
