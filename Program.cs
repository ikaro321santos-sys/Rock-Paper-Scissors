using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        enum RPS
        {
            Rock,
            Paper,
            Scissors
        }
        static void Main(string[] args)
        {
            //Bot choices
            Random rand = new Random();
            RPS botChoice = (RPS)rand.Next(0, 3);
            Console.WriteLine(botChoice);

            //Player Choice
            Console.WriteLine("Rock / Paper / Scissors");
            Console.WriteLine(" [R] /  [P]  /    [S]  ");
            String Answer = Console.ReadLine().ToUpper();
            RPS PlayerChoice;
            if (Answer == "R") PlayerChoice = RPS.Rock;
            else if (Answer =="P") PlayerChoice = RPS.Paper;
            else if (Answer == "S") PlayerChoice= RPS.Scissors;
            else{
                Console.WriteLine("Invalid Answer.");
                return;
            }
            Console.WriteLine($"Your Choice {PlayerChoice}");

            //Results
            if (PlayerChoice == botChoice)
            {
                Console.WriteLine("Tie!");
            }
            else if (
                (PlayerChoice == RPS.Rock && botChoice == RPS.Scissors) ||
                (PlayerChoice == RPS.Paper && botChoice == RPS.Rock) ||
                (PlayerChoice == RPS.Scissors && botChoice == RPS.Paper)
            ){
                Console.WriteLine("You Win!");
            } else{
                Console.WriteLine("You Lose!");
            }
        }           
    }
}
