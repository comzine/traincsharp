// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input, firstname, surname;
            int age;
            Console.Write("Please enter your age: ");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);
            Console.Write("Please enter your name: ");
            firstname = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            surname = Console.ReadLine();
            if (age > 17)
            {
                Console.WriteLine(surname + ", you are a grown up!");
            }
            else
            {
                Console.WriteLine(firstname + ", you are a child!");
            }
            Console.ReadKey();
        }
    }
}