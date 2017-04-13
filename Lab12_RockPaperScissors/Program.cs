using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            IPlayer user = new UserPlayer(name);

            bool run = true;

            while (run == true)
            {
                Console.WriteLine("Who would you like to play against? The Rock or Randy");
                string challenger = Console.ReadLine();

                IPlayer theRock = new RockPlayer("The Rock");

                IPlayer theRandom = new RandomPlayer("Randy");

                Console.WriteLine("Rock, Paper, or Scissors? (Enter 1 for rock, enter 2 for paper, enter 3 for scissors): ");


                string userAction = user.generateRoshambo();
                if (challenger == "The Rock")
                {
                    //playing against the rock
                    if (userAction == "rock")
                    {
                        switch (theRock.generateRoshambo())
                        {
                            case "rock":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("The Rock threw rock");
                                Console.WriteLine("Draw");
                                break;
                            //indicates a draw
                            default:
                                break;
                        }
                    }
                    else if (userAction == "paper")
                    {
                        switch (theRock.generateRoshambo())
                        {
                            case "rock":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("The Rock threw rock");
                                Console.WriteLine(user.Name + " wins!");
                                break;
                            //indicates a win
                            default:
                                break;
                        }
                    }
                    else if (userAction == "scissors")
                    {
                        switch (theRock.generateRoshambo())
                        {
                            case "rock":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("The Rock threw rock");
                                Console.WriteLine("The Rock wins!");
                                break;
                            //indicates a loss
                            default:
                                break;
                        }
                    }
                }
                else if (challenger == "Randy")
                {
                    //playing against randy
                    if (userAction == "rock")
                    {
                        switch (theRandom.generateRoshambo())
                        {
                            case "rock":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw rock");
                                Console.WriteLine("Draw!");
                                break;
                            case "paper":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw paper");
                                Console.WriteLine("Randy wins!");
                                break;
                            case "scissors":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw scissors");
                                Console.WriteLine(user.Name + " wins!");
                                break;
                            default:
                                break;
                        }
                    }
                    else if (userAction == "paper")
                    {
                        switch (theRandom.generateRoshambo())
                        {
                            case "rock":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw rock");
                                Console.WriteLine(user.Name + "wins!");
                                break;
                            case "paper":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw paper");
                                Console.WriteLine("Draw!");
                                break;
                            case "scissors":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw scissors");
                                Console.WriteLine("Randy wins!");
                                break;
                            default:
                                break;
                        }
                    }
                    else if (userAction == "scissors")
                    {
                        switch (theRandom.generateRoshambo())
                        {
                            case "rock":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw rock");
                                Console.WriteLine("Randy wins!");
                                break;
                            case "paper":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw paper");
                                Console.WriteLine(user.Name + " wins!");
                                break;
                            case "scissors":
                                Console.WriteLine(user.Name + " threw " + userAction);
                                Console.WriteLine("Randy threw scissors");
                                Console.WriteLine("Draw!");
                                break;
                            default:
                                break;
                        }
                    }
                }
                run = ContinueClass.Continue();
            }
           // run = ContinueClass.Continue();
            
        }
    }
}
