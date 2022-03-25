using System;
namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam result.");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());
            
            if (grade == 'A')
            {
                Console.WriteLine("Outstanding!!!");
            }
            else if (grade == 'B')
            {
                Console.WriteLine("Superior!!");
            }
            else if (grade == 'C')
            {
                Console.WriteLine("Good!");
            }
            else if (grade == 'D')
            {
                Console.WriteLine("Satisfactory.");
            }
            else if (grade == 'E')
            {
                Console.WriteLine("Low Pass.");
            }
            else if (grade == 'F')
            {
                Console.WriteLine("Failure.");
            }
            else
            {
                Console.WriteLine("What?!");
            }
        }
    }
}