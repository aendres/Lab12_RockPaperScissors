using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    class Roshambo
    {
        public string getRoshambo(int result)
        {
            string[] roshambo = new string[4];
            roshambo[0] = "";
            roshambo[1] = "rock";
            roshambo[2] = "paper";
            roshambo[3] = "scissors";
            string value = roshambo[result];

            return value;
        }
    }
}
