using System;

namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum, max, min, count;
            //Tutorial
            List<string> names = new List<string> { "Trinity", "Leo", "Morpheous", "Smith" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine("There are " + names.Count + " names in my List.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }



            //Assignment 1
            List<string> colors = new List<string> { "Red", "Orange", "Blue", "Green", "Purple" };
            int randomIndex = Random.Shared.Next(colors.Count);

            Console.WriteLine(colors[0] + ", " + colors[1] + ", " + colors[2] + ", " + colors[3] + ", " + colors[4]);

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(colors[randomIndex]);
            }
            randNum = generator.Next(5);

            //Assignment 2
            
            Console.WriteLine("How many numbers do you need?");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum value");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a minimum value");
            min = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();
            count = numbers.Count;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(colors[randomIndex]);
            }
        }
    }
}
