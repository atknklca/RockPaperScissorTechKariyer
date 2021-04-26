using System;

namespace RockPaperScissorTechKariyer
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] choices = new string[3] { "Rock", "Paper", "Scissor" };
           
            const int aUserChoice = 1;  //  Player A always chooses Paper
            int bUserChoice;    //  using Random class

            int aWin = 0;
            int bWin = 0;
            int round, roundCount;
            roundCount = round = 100;

            while (roundCount>0)
            {

                Random rnd = new Random();
                bUserChoice = rnd.Next(0, 3);

                switch (choices[aUserChoice])
                {
                    case "Rock":
                        if (choices[bUserChoice] == "Paper") bWin++;
                         else if (choices[bUserChoice] == "Scissor") aWin++;
                        break;

                    case "Paper":
                        if (choices[bUserChoice] == "Rock") aWin++;
                        else if (choices[bUserChoice] == "Scissor") bWin++;
                        break;

                    case "Scissor":
                        if (choices[bUserChoice] == "Rock") bWin++;
                        else if (choices[bUserChoice] == "Paper") aWin++;
                        break;

                    default:
                        Console.WriteLine("Error(switch)");
                        break;
                }

                roundCount--;
            }

            Console.WriteLine(
                $"Player A wins {aWin} of {round} games \n" +
                $"Player B wins {bWin} of {round} games \n" +
                $"Tie: {round-(aWin+bWin)} of {round} games");
        }
    }
}
