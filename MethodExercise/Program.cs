using System;

namespace MethodExercise
{
    internal class MethodExercise 
    {
        static string reverseLetters(string word) {
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            wordArray[0] = char.ToUpper(wordArray[0]);
            Console.WriteLine(wordArray[wordArray.Length - 1]);
            wordArray[wordArray.Length - 1] = char.ToLower(wordArray[wordArray.Length - 1]);
            return new string(wordArray);
        }      
         static void runStory() {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Great, now what is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("Ok, now what is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("That's fine, now what is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"Did you know I knew somebody else named {reverseLetters(name)} and they were loathe to see {animal} and the kind they hated to see most were the kind that were colored {color}. They told me they hated the band {band} and if they ever heard about {animal} playing in {band} that would probably be the worst thing they could hear.");
        }

        static int add(params int[] nums) {
            int sum = 0;
            foreach (int num in nums) {
                sum = sum + num;
            };
            return sum;
        }
        static int subtract(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum = sum - num;
            };
            return sum;
        }
        static int multiply(params int[] nums)
        {
            int initial = 1;
            foreach (int num in nums)
            {
                initial = initial * num;
            };
            return initial;
        }

        static int divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        static int modulo(int dividend, int divisor)
        {
            return dividend % divisor;
        }

        static void Main()
        {
            Console.WriteLine(add(1, 1, 1, 1, 1));
            Console.WriteLine(subtract(1, 1, 1, 1, 1));
            Console.WriteLine(multiply(1, 2, 3, -4));
            Console.WriteLine(divide(24, 6));
            Console.WriteLine(modulo(25, 6));
            runStory();
        }
    }
}