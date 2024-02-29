using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorsRock.Tests
{
    public class PSRTests
    {
        [Test]
        public void RockBeatsScissorsPlayer1Wins()
        {
            GameManagerDI gm = new GameManagerDI(new ForcedPlayer(Choice.Rock), new ForcedPlayer(Choice.Scissors));

            Assert.That(gm.PlayRound(), Is.EqualTo(RoundResult.Player1Win));
        }

        [Test]
        public void RockBeatsScissorsPlayer2Wins()
        {
            GameManagerDI gm = new GameManagerDI(new ForcedPlayer(Choice.Scissors), new ForcedPlayer(Choice.Rock));

            Assert.That(gm.PlayRound(), Is.EqualTo(RoundResult.Player2Win));
        }
    }
}
