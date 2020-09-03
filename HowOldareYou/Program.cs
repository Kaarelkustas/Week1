using System;

namespace HowOldareYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, What's your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine("What is your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You are " + Age + " years old.");
        }
    }
}
