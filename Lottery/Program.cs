namespace Lottery
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Lottery
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Check if you win, enter your numbers");

            while (true)
            {
                List<string> symbols = new List<string>(Console.ReadLine().Split(",").Select(s => s.Trim()).ToList());
                if (symbols.SequenceEqual(new List<string> { "@", "@", "@", "@", "@", "@" }))
                {
                    continue;
                }
                if (symbols.SequenceEqual(new List<string> {"X", "X", "X"}))
                {
                    Console.WriteLine("Yes");
                }
                else if (symbols.SequenceEqual(new List<string> {"S", "S", "S"}))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                    break;
                }
            }
        }
    }

}
