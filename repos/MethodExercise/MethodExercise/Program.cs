using System;

namespace MethodExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);


            //---------------Exercise 1----------------------------------------
            //Name: Cheyenne
            //Favorite Color: Green
            //Favorite Animal: Tiger
            //Favorite Band: Goo Goo Dolls

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile.");
            Console.WriteLine("---------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            //------------Exercise 2-------------------------------------------

        }
    }
}
