using System;

namespace ltr_input
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter, letter1, letter2;

            Console.Write("Input Letter ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter again ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter one more time ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
        }
    }
}
