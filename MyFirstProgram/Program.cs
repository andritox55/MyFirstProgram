using System.ComponentModel.Design;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int number = 10;

            // check if number is bigger than 10 if not print else statement
            if (number > 10)
            {
                Console.WriteLine("Talet är stort!");
            } else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }


            // takes input from user and print name
            Console.WriteLine("Vad heter du?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hej dezz {name}!");


            // print every number from 0 to a chosen number
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}