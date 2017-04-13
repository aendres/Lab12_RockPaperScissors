using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public interface IPlayer
    {
        string Name { get; set; }

        string generateRoshambo();
       
    }
}
