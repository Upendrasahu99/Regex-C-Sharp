//validate username, username should start with capital and minimum length is 3 or more.
using System;
using System.Text.RegularExpressions;

namespace ClassProblem1
{
    internal class Program
    {
        public void CheckUserName()
        {
            string pattern = "[A-Z]{1}[a-z]{3,}";

            Console.WriteLine("Enter the User name");
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);   
            
            if( regex.IsMatch(input))
            {
                Console.WriteLine("Username valid");
            }
            else
            {
                Console.WriteLine("Username not valid");
            }
        }
       
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CheckUserName();
        }
    }
}
