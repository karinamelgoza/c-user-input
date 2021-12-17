using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total: {Add()}");
        }

        public static int Add()
        {
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            string num2 = Console.ReadLine();
            return int.Parse(num1) + int.Parse(num2);
        }
    }
}
