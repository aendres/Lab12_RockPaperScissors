using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public static class Validator
    {
        public static int ValidateInput()
        {
            int result;
            bool tryParseSucceded = int.TryParse(Console.ReadLine(), out result);

            if (tryParseSucceded)
            {
                return result;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("That is not a vaild input, please try again.");
                return ValidateInput();
            }
        }
    }
}
