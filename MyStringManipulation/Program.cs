using System;

namespace MyStringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence: \n");
            string sentence = Console.ReadLine();

            string replace = sentence.Replace(" ", "_");
            string leading = sentence.TrimStart(' ');
            string trailing = sentence.TrimEnd(' ');
            string upper = sentence.ToUpper();

            Console.WriteLine("Original sentence: '" + sentence +
                "'\nAfter replacing spaces with underscores: '" + replace +
                "'\nAfter removing leading spaces: '" + leading +
                "'\nAfter removing trailing spaces: '" + trailing +
                "'\nAfter replacing lowercase with uppercase: '" + upper);
        }
    }
}
