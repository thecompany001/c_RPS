using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.WriteLine("Choose between ROCK, PAPER, or SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW! \n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS! \n\n");
                                scorePlayer++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW! \n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!");
                                scorePlayer++;
                            }
                            else (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("COMPUTER WINS!");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW! \n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!");
                                scorePlayer++;
                            }
                            else (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("COMPUTER WINS!");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER WINS!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Computer wins");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again? (Y / N)");
                string loop = Console.ReadLine();
                if (loop == "y" | "Y")
                {
                    playAgain = true;
                }
                else (loop == "n" | "N")
                {
                    playAgain = false;
                }
            }
        }
    }
}
