namespace Scores
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Scores
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter results in format wins-x, Draw-y,Losses-z:");
            List<string> results = Console.ReadLine().Split(new char[] { ',', '-' }).Select(r => r.Trim()).ToList();
            if (results.Count() < 6)
            {
                Console.WriteLine("it is not correct format");
            }
            else if (!int.TryParse(results[1], out _))
            {
                Console.WriteLine("it is not correct format");
            }
            else if (!int.TryParse(results[3], out _))
            {
                Console.WriteLine("it is not correct format");
            }
            else if (!int.TryParse(results[5], out _))
            {
                Console.WriteLine("it is not correct format");
            }
            else
            {
                int sum = (int.Parse(results[1])) * 3 + (int.Parse(results[3])) * 1 + (int.Parse(results[5]) * 0);
                Console.WriteLine($"Total points: {sum}");
            }
        }

    }
}
