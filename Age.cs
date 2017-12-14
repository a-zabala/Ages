using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your birthday?");
            var birthDate = Console.ReadLine();
            var start1 = DateTime.Parse(birthDate);
            var end =  DateTime.Today - start1;
            var years = end.TotalDays / 365;
            Console.WriteLine(years);
            Console.ReadLine();        }
    }
}