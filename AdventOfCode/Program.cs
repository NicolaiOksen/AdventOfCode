using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("============ Advent of Code ============");

            Console.WriteLine(new Day1(DataProvider.Captcha).ToString());
            Console.WriteLine(new Day2(DataProvider.Table).ToString());

            Console.ReadLine();
        }
    }
}
