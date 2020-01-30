using System;

namespace ClassProject_2_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");          

            // Try catch statement to check whether or not the user input is valid
            try
            {
                string input = Console.ReadLine();
                int score = int.Parse(input);
             
                // if - else statment to return what letter grade the user should get
                if ((score >= 98) && (score <= 100))
                {
                    Console.WriteLine("Your Letter grade ought to be A+");
                }
                else if ((score >= 92) && (score <= 97))
                {
                    Console.WriteLine("Your Letter grade ought to be A");
                }
                else if ((score >= 90) && (score <= 91))
                {
                    Console.WriteLine("Your Letter grade ought to be A-");
                }
                else if ((score >= 88) && (score <= 89))
                {
                    Console.WriteLine("Your Letter grade ought to be B+");
                }
                else if ((score >= 82) && (score <= 87))
                {
                    Console.WriteLine("Your Letter grade ought to be B");
                }
                else if ((score >= 80) && (score <= 81))
                {
                    Console.WriteLine("Your Letter grade ought to be B-");
                }
                else if ((score >= 78) && (score <= 79))
                {
                    Console.WriteLine("Your Letter grade ought to be C+");
                }
                else if ((score >= 72) && (score <= 77))
                {
                    Console.WriteLine("Your Letter grade ought to be C");
                }
                else if ((score >= 0) && (score < 70))
                {
                    Console.WriteLine("Letter grade below C! You better get back to study");
                }
                else
                {
                    Console.WriteLine("Values must not be less than 0 and not exceed 100");
                }
            }
            // End of try
            catch
            {
                Console.WriteLine("Values must lie between 0 and 100.");
                Console.WriteLine("Press ESC to exit.");
            }
            }
        }
}
