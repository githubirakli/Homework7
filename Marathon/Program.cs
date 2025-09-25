namespace Marathon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter training hours per day in format x,x,x,x...");
            var hours = Console.ReadLine().Split(",").Select(s => s.Trim()).ToList();
            var sum = 0;
            int i;
            for ( i=0; i< hours.Count; i++)
            {
                if (!int.TryParse(hours[i], out _))
                {
                    Console.WriteLine("Change format (all must be numbers)");
                    return;
                }
                else if(i<0){  Console.WriteLine("OUT OF RANGE"); return;   


                }


                else {
                    if (i>0 &&int.Parse(hours[i ]) > int.Parse(hours[i - 1])) {
                        sum++;

                    }

                }  
            }
                    Console.WriteLine(sum);

        }
    }
}
