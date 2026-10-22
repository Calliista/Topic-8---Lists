namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tutorial
            List<string> names = new List<string> { "Trinity", "Leo", "Morpheous", "Smith" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine("There are " + names.Count + " names in my List.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }

            //Assignment 1


        }
    }
}
