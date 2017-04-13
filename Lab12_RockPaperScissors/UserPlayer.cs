using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class UserPlayer : IPlayer
    {
        public UserPlayer(string name)
        {
            Name = name;

        }

        public string Name { get; set; }

        public string generateRoshambo()
        {
            Roshambo person = new Roshambo();

            string personChoice = person.getRoshambo(Validator.ValidateInput());

            return personChoice;
        }
    }
}
