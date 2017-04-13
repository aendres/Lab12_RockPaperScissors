using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class ContinueClass
    {
        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n)");
            string input = Console.ReadLine().ToLower();

            bool run;
            if(input == "n" || input == "no")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y" || input == "yes" )
            {
                run = true;
            }
            else
            {
                Console.WriteLine("That is not a vaild input.");
                run = Continue();
            }
            return run;
        }
    }
}
