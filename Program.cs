using System;

namespace MiniChallenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            
            Console.WriteLine("What time did you wake up?");
            string userWakeUp = Console.ReadLine();

            Console.WriteLine(userName + " woke up today at " + userWakeUp);
        }
    }
}
