using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,28);
            int randomMinNumber = 100;
            int randomMaxNumber = 999;

            Console.WriteLine("Случайное число: " + randomNumber);
            Console.ReadLine();

            for (int i = randomMinNumber; i <= randomMaxNumber; i += randomNumber)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
