using System;
namespace Random1
{
    class Program
    {
        static void Main()
        {          
            Random rnd = new Random();
            string[] firstNames = new string[] 
            { "Denis", "Rafi", "Denis", "Rafi", "Denis" };

            string[] secondNames = new string[]
            { "Denis", "Rafi", "Denis", "Rafi" };

            string[] cities = new string[]
            { "London", "Paris", "New York", "Singapore", "Hong Kong" };

            string[] reviews1 = new string[]
            { "Hello World!", "C#", "C++", "C--" };

            string[] reviews2 = new string[]
            { "Loops", "Arrays", "Numeral Systems", "Methods", "Recursion" }; 

            Console.WriteLine("{0} {1}\n {2} {3}, {4}.", reviews1[rnd.Next(4)], 
                reviews2[rnd.Next(5)], firstNames[rnd.Next(5)],
                secondNames[rnd.Next(4)], cities[rnd.Next(5)]);
            Console.Title = "By Denis Rafi";
            Console.ReadKey();          
        }
    }
}


