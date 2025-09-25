namespace LengthOf
{
    internal class Program
    {
        static void Main(string[] args)
        {    List<string> wordsList = new List<string>() { "Hello", "World" , "Programming", "communication"};
            Console.WriteLine("Please enter number of chars");

            int number=int.Parse(Console.ReadLine());

           
            foreach (var word in wordsList)
            { if (word.Length>=number)
                Console.WriteLine(word);
               
                       
            }
                    Console.WriteLine("No elements found"); 
        }
    }
}
