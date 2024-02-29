// See https://aka.ms/new-console-template for more information
using PaperScissorsRock;

Console.WriteLine("Hello, World!");

var gm = new GameManager();

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