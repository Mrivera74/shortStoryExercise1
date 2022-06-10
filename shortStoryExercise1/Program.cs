using System;

namespace shortStoryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is ytour name?");
            //string username = Console.ReadLine();

            //Console.WriteLine("What is you favorite color?");
            //string favColor = Console.ReadLine();

            //Console.WriteLine("What is your favorite Zoo animal?");
            //string favZooAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite resturant?");
            //string favRest = Console.ReadLine();

            //Console.WriteLine("What is your favorite flavor ice cream?");
            //string favIceCream = Console.ReadLine();

            //Console.WriteLine($"{username} remembers the day the family went to the Zoo. {username} had their favorite {favColor} T-shirt. Where they were able to see their favorite zoo animal, {favZooAnimal}. Then the family finished the day by getting dinner at their favorite resturant {favRest} and also going to the ice cream shop for their favorite ice cream, {favIceCream}.");

            //Console.WriteLine("Give the first number you want to add?");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Give the second number you want to add?");
            //int num2 = int.Parse(Console.ReadLine());

            //int sum = Sum(num1, num2);
            //Console.WriteLine($"{num1} + {num2} = {sum}");

            //Console.WriteLine("Give first number to multiply");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Give sencond number to multiply");
            //int y = int.Parse(Console.ReadLine());

            //int product = Multiply(x, y);
            //Console.WriteLine($"{x} * {y} = {product}");

            Console.WriteLine("Give dividend");
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine("Give divisor");
            int V = int.Parse(Console.ReadLine());

            int module = Module(D, V);

            int quotient = Quotient( D, V);
            Console.WriteLine($"{D}/{V}= {quotient} R{module}");

        }

        //public static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
           
        //}

        //public static int Multiply (int x, int y)
        //{
        //    return x * y;
        //}

        public static int Quotient (int D, int V)
        {
            return D / V;
        }

        public static int Module (int D, int V)
        {
            return D % V;
        }
    }
}


