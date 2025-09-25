namespace Homework7
{
    using System;
    // using System.Linq;

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a radius");
            var R = Console.ReadLine();
            double areas = int.Parse(R) * int.Parse(R) * 2;
            double areaS = int.Parse(R) * int.Parse(R) * 4;
            double areaC = int.Parse(R) * int.Parse(R) * Math.PI;
            if (!int.TryParse(R, out _))
            {
                Console.WriteLine("Please enter a digit");

            }
            else
            {

                Console.WriteLine($" Area of a big squeare is {areaS}");
                Console.WriteLine($" Area of a small squeare is {areas}");
                Console.WriteLine($" Area of cyrcle is {areaC}");
                double Difference = areaS - areas;
                Console.WriteLine($" area of big squeare  - area of small squeare =  {Difference}");

            }
        }
    }

}
