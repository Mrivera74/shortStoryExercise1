using System;

namespace shortStoryExercise
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("What is ytour name?");
            string username = Console.ReadLine ();

            Console.WriteLine ("What is you favorite color?");
            string favColor = Console.ReadLine ();

            Console.WriteLine ("What is your favorite Zoo animal?");
            string favZooAnimal = Console.ReadLine ();  

            Console.WriteLine ("What is your favorite resturant?");
            string favRest = Console.ReadLine ();

            Console.WriteLine ("What is your favorite flavor ice cream?");
            string favIceCream = Console.ReadLine ();

            Console.WriteLine ($"{username} remembers the day the family went to the Zoo. {username} had their favorite {favColor} T-shirt. Where they were able to see their favorite zoo animal, {favZooAnimal}. Then the family finished the day by getting dinner at their favorite resturant {favRest} and also going to the ice cream shop for their favorite ice cream, {favIceCream}.");
        }
    }
}

