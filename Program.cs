using System;

namespace rock_paper_scisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Rock Papper Scisors");

            Random fistshake = new Random();
            int  rock;
            int   paper;
            int   scisors;

            Console.WriteLine("rock is your fist, paper hand spred out, scissors are your fist 2 fingers spred out");
            Console.WriteLine("if you pick rock, rock beats scissors and paper beats rock. Rock ties with rock");
            Console.WriteLine("paper gets beaten by scisors and beats rock but ties with paper");
            Console.WriteLine("scisors beats papers ties with scisors and looses to rock");
            Console.WriteLine("Shake your fist 1 2 3  rock paper scisors");
            
        }
    }
}