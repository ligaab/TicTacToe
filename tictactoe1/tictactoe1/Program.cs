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
    input = Game.correctInput();

    {
        if (flag == 1)
        {
            Console.WriteLine($"Spēlētājs  {player1.Name} ir uzvarējis");
            choiceGameover();
        }
       
        else if (input == false)
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("izvēlies citu skaitli!");
            step2 = int.Parse(Console.ReadLine());
        }
        if (board == -1)
        {
            Console.WriteLine("Viss laukums ir aizpildīts - NEZŠĶIRTS REZULTĀTS!");
            choiceGameover();
        }
        else if (choice == 2)
        {
            break;
        }
    
    }

    Console.WriteLine("speletaja 2 gajiens");
    step2 = int.Parse(Console.ReadLine());
    pos[step2] = "O";
    Console.Clear();
    DrawBoard();
    flag = Game.CheckWin();
    board = boardFull();
    input = Game.correctInput();

    {
        if (flag == 2)
        {
            Console.WriteLine($"Spēlētājs  {player2.Name} ir uzvarējis");
            choiceGameover();
        }
      
        else if (input == false)
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("izvēlies citu skaitli!");
            step1 = int.Parse(Console.ReadLine());
        } 
    }
    if (board == -1)
    {
        Console.WriteLine("Viss laukums ir aizpildīts - NEZŠĶIRTS REZULTĀTS!");
        choiceGameover();
    }
    else if (choice == 2)
    {
        break;
    }
}
while (flag == 0 || choice == 1);




















// jāizveido pārbaudes katrai rindai ar uzvaru
// spēles nobeigums
