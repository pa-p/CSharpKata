using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorsRock
{
    public class GameManagerDI
    {
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public GameManagerDI(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public RoundResult PlayRound()
        {
            var p1 = _player1.GetChoice();
            var p2 = _player2.GetChoice();

            Console.WriteLine($"Player 1 picks {p1} and Player 2 picks {p2}");            

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
