using PaperScissorsRock;

//var gm = new GameManager();
var gm = new GameManagerDI(new HumanPlayer(), new ComputerPlayer());

do
{
    var result = gm.PlayRound();

    if(result == RoundResult.Player1Win)
        Console.WriteLine("Player 1 Wins!");

    else if (result == RoundResult.Player2Win)
        Console.WriteLine("Player 2 Wins!");
    else
        Console.WriteLine("It's a draw!");

    Console.WriteLine("Play again (Y/N)? ");
} while (Console.ReadLine().ToUpper() == "Y");