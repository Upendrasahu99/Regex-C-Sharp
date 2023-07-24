using System;
using System.Text.RegularExpressions;

namespace Question1
{
    internal class Program
    {
        public  void PatternMatch() 
        {
            string pattern = "a{1}b{2,3}";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            if( regex.IsMatch(input))
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
            program.PatternMatch();
        }
    }
}
