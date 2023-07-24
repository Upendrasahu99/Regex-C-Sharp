// 
using System;
using System.Text.RegularExpressions;

namespace Question2
{
    internal class Program
    {
        public void MatchPattern()
        {
            string pattern = "[a-z]+(_[a-z]+)";

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            if(regex.IsMatch(input))
            {
                Console.WriteLine("Pattern match");
            }
            else
            {
                Console.WriteLine("Pattern not match");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.MatchPattern();
            Console.ReadLine();
        }
    }
}
