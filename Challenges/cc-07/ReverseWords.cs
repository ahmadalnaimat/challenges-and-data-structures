using System;

namespace ReverseWords
{
    public class ReverseWord
    {
        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static void Main(string[] args)
        {
            string input1 = "csharp is programming language";
            string input2 = "Reverse the words in this sentence";
            string input3 = "challenges and data structures";

            Console.WriteLine(ReverseWords(input1));
            Console.WriteLine(ReverseWords(input2));
            Console.WriteLine(ReverseWords(input3));
        }
    }
}
