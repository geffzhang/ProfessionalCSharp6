﻿using ExtensionMethods.Foo;
using static System.Console;
// using ExtensionMethods.Bar; // importing both namespaces creates an ambiguous compiler error

namespace ExtensionMethods
{
    namespace Foo
    {
        public static class StringExtensions
        {
            public static int GetWordCount(this string s) =>
                s.Split().Length;
            
        }

    }

    namespace Bar
    {
        public static class StringExtensions
        {
            public static int GetWordCount(this string s) =>
                s.Split().Length;
            
        }

    }

    public class Program
    {
        public static void Main()
        {
            string fox = "the quick brown fox jumped over the lazy dogs down 9876543210 times";
            int wordCount = fox.GetWordCount();
            WriteLine($"{wordCount} words");
            ReadLine();
        }
    }
}
