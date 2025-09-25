namespace Salaries
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Security.Cryptography.X509Certificates;

    public class Salaries
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter working hours for this week in format x,x,x,x,x,x,x");
            
            var workingHours = Console.ReadLine().Split(",").Select(s => s.Trim()).ToList();
              var sum1 = 0;
              var sum2 = 0;
              int i;
            //foreach (var hour in workingHours) {
            //    bool allAreNumbers = workingHours.All(s => int.TryParse(s, out _)); }

            if (workingHours.Count != 7)
            {
                Console.WriteLine("Change format");
            }

            else
            {
                for (i = 0; i <7; i++)
                {
            if (!int.TryParse(workingHours[i], out _ ) )
            {
                Console.WriteLine("Change format (all must be numbers)");
                return;
            }
                    else if (i < 5){
                                if (int.Parse(workingHours[i]) <= 8)
                                {
                                    sum1 += int.Parse(workingHours[i]) * 10;
                                }
                                else  
                                {
                                    sum1 += (8 * 10) + ((int.Parse(workingHours[i]) - 8) * 15);
                                }
                                
                     

                            }
                    else
                    { 
                        
                        sum2 += int.Parse(workingHours[i]) * 20;

                    }
                }
                    var sum = sum1+sum2;
                Console.WriteLine($"Total salary is {sum}");
            }
        }

    }

}
