using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class RandomPlayer : IPlayer
    {
        public RandomPlayer(string name)
        {
            Name = name;
            name = "Randy";
        }

        public string Name { get; set; }

        public string generateRoshambo()
        {
            Random rnd = new Random();
            int generate = rnd.Next(0,3);
            Roshambo random = new Roshambo();
            string randomChoice = random.getRoshambo(generate);
            return randomChoice;
            
        } 
    }
}
