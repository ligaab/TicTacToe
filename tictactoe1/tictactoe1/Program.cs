


using tictactoe1;
using static tictactoe1.Game;
using static tictactoe1.Simbol;




Console.WriteLine("Laipni lugts spele TicTacToe");

HumanPlayer player1 = new HumanPlayer();

player1.GetPlayerName();
player1.Simbol = Simbol.X;

HumanPlayer player2 = new HumanPlayer();
player2.GetPlayerName();
player2.Simbol = Simbol.O;


//tictactoe1.Player diferntPlayer = tictactoe1.Player.Player1;

//char charValue = (char)Player1;
Console.WriteLine($"Spēlētājs 1 ir {player1.Simbol}, tavs vards ir {player1.Name}");

//char charValue2 = (char)Player2;
Console.WriteLine($"Spēlētājs 2 ir {player2.Simbol}, tavs vards ir {player2.Name}");


    Console.WriteLine("Katram speletajam ir simbols X vai O. Uzvar tas kurs pirmais savac tris vienadus simbolus rinda, kolonna, pa diognali");
    Console.WriteLine();
    Console.WriteLine();


DrawBoard();

do
{

    Console.WriteLine("speletaja 1 gajiens");
    step1 = int.Parse(Console.ReadLine());
    pos[step1] = "X";
    Console.Clear();
    DrawBoard();
    
    flag = Game.CheckWin();
    board = boardFull();

    if (Game.flag == 1)

    {
        break;
    }
    input = Game.correctInput();
    if (input == false)
    {
        Console.WriteLine("izvēlies citu skaitli!");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("");
    }
    


    Console.WriteLine("speletaja 2 gajiens");
    step2 = int.Parse(Console.ReadLine());
    pos[step2] = "O";
    Console.Clear();
    DrawBoard();

    flag = Game.CheckWin();
    board = boardFull();

    if (Game.CheckWin() == 2)

    {
        break;
    }
    input = Game.correctInput();
    if (input == false)
    {
        Console.WriteLine("izvēlies citu skaitli!");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("");
    }
   }
while (flag == 0);


    if (flag == 2)
    {
        Console.WriteLine($"Player  {player2.Name} has von");
        Console.WriteLine("Spēlējam vēlreiz?");

        DrawBoard();

    }
    else if (flag == 1)
    {

        Console.WriteLine($"Player  {player1.Name} has von");
        Console.WriteLine("Spēlējam vēlreiz?");


    }

    else if (Game.boardFull() != -1)
    {
        Console.WriteLine("Viss laukums ir aizpildīts - NEZŠĶIRTS REZULTĀTS!");

    }















// jāizveido pārbaudes katrai rindai ar uzvaru
// spēles nobeigums
