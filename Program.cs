using System;

namespace rock_paper_scisors
{
    class Program
    {
        static void Main(string[] argus)
        {
            Console.WriteLine(" Rock Papper Scisors");
            {
          
            }
            Console.WriteLine("rock is your fist, paper hand spred out, scissors are your fist 2 fingers spred out");
            Console.WriteLine("if you pick rock, rock beats scissors and paper beats rock. Rock ties with rock");
            Console.WriteLine("paper gets beaten by scisors and beats rock but ties with paper");
            Console.WriteLine("scisors beats papers ties with scisors and looses to rock");
            Console.WriteLine("Shake your fist 1, 2, 3  rock paper scisors!!! ");

            string inputPlayer,inputCPU;
            int randomInt;
            int scorePlayer = 10;
            int scoreCPU = 10;
            bool playAgain = true;

            while (playAgain)
            {

            }

            while (scorePlayer < 3 && scoreCPU < 3)
            {
                Console.WriteLine("Do you want to play Rock Paper or Scissors? ");
                inputPlayer = Console.ReadLine();
                inputPlayer.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                { 
                case 1:;
                        inputCPU = "rock";
                        Console.WriteLine("Computer chose rock");
                        if (inputPlayer == "rock")
                        {
                            Console.WriteLine("TIE!!\n\n");
                        }
                        else if (inputPlayer == "paper")
                        {
                            Console.WriteLine("Player wins!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "rock")
                        {
                            Console.WriteLine("TIE\n\n");

                        }
                        break;
                    case 2:
                        inputCPU = "Paper";
                        Console.WriteLine("Computer chose paper");
                        if (inputPlayer == "paper")
                        {
                            Console.WriteLine("TIE!!\n\n");
                        }
                        else if (inputPlayer == "rock")
                        {
                            Console.WriteLine("cpu wins!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "scissors")
                        {
                            Console.WriteLine("Player Wins\n\n");
                            scoreCPU++;

                        }
                        break;

                    case 3:;
                         inputCPU = "scissors";
                        Console.WriteLine("Computer chose scissors");
                        if (inputPlayer == "scissors")
                        {
                            Console.WriteLine("TIE!!");

                        }
                        else if (inputPlayer == "rock")
                        {
                            Console.WriteLine("Player wins\n\n");
                            scorePlayer++;
                        }

                        else if (inputPlayer == "paper")
                        {
                            Console.WriteLine("CPU wins!!\n\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
            if (scorePlayer == 3)
            {
                Console.WriteLine("Player won");
            }
            else if (scoreCPU == 3)
            {
                Console.WriteLine("CPU won");
            }
            else
            {

            }

            Console.WriteLine("Do you want to go again? y/n");

        }
    }
}