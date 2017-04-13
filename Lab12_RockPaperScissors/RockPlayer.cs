using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class RockPlayer : IPlayer
    {
        public RockPlayer(string name)
        {
            Name = name;
            name = "The Rock";
        }

        public string Name { get; set;}

        public string generateRoshambo()
        {
            Roshambo rock = new Roshambo();
            string rockChoice = rock.getRoshambo(1);
            return rockChoice;
        }
    }
}
