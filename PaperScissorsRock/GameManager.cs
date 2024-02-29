using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorsRock
{
    public class GameManager
    {
        Random _random = new Random();


        public RoundResult PlayRound()
        {
            // Player1 (Human)
            Choice p1;
            do
            {
                Console.WriteLine($"Enter Choice: (R)ock, (P)aper, or (S)cissors: ");
                var input = Console.ReadLine().ToUpper();
                if (input == "R")
                {
                    p1 = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    p1 = Choice.Paper;
                    break;
                }
                else if (input == "S")
                {
                    p1 = Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again!");
                }
            } while (true);

            // Player2 (Cpu)
            Choice p2 = (Choice)_random.Next(0, 3);
            Console.WriteLine($"Player 2 picked {p2}");

            if (p1 == p2)
                return RoundResult.Draw;

            if (p1 == Choice.Rock && p2 == Choice.Scissors ||
                p1 == Choice.Paper && p2 == Choice.Rock ||
                p1 == Choice.Scissors && p2 == Choice.Paper)
                return RoundResult.Player1Win;

            return RoundResult.Player2Win;
        }


    }
}
