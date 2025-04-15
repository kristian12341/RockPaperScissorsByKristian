const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r"  playerMove == "rock")
    {
    playerMove = Rock;
}

if (playerMove == "p"  playerMove == "paper")
    {
    playerMove = Paper;
}

if (playerMove == "s"  playerMove == "Scissors")
    {
    playerMove = Scissors;
}

else
{
    Console.WriteLine("Invalid Input. Try Again..."); return;
    return;
}

    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);
    string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break
            case 2:
        computerMove = Paper;
        break;
        case 3:
        computerMove = Scissors;
        break;
}

Console.WriteLine($"The computre chose {computerMove}.");
if ((playerMove == Rock && computerMove == Scissors) ||
   (playerMove == Scissors && computerMove == Rock) ||
    (playerMove == Scissors && computerMove == Paper))
{
    Console.WriteLine("You win.")
}

else if
    ((playerMove == Rock && computerMove == Paper) ||
    (playerMove == Paper && computerMove == Scissors) ||
    (playerMove == Scissors && computerMove == Rock))

{
    Console.WriteLine("You loose.")
}
else
{ 
    Console.WriteLine("This game was a draw.")